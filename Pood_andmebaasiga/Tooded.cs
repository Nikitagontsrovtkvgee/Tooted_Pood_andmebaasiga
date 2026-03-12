using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    public partial class Tooded : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");
        string piltPath = "";
        string kasutajaRoll = "";

        public Tooded(string roll)
        {
            InitializeComponent();
            this.kasutajaRoll = roll;

            // Add image column to the grid
            var imgCol = new DataGridViewImageColumn();
            imgCol.Name = "PiltImage";
            imgCol.HeaderText = "Pilt";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 80;
            dataGridViewTooded.Columns.Add(imgCol);
            dataGridViewTooded.RowTemplate.Height = 80;

            RefreshEverything();

            // Role-based access
            if (kasutajaRoll != "Omanik" && kasutajaRoll != "Admin")
            {
                btnLisa.Enabled = false;
                btnUuenda.Enabled = false;
                btnKustuta.Enabled = false;
                btnLisaKat.Enabled = false;
                btnAdminPaneel.Visible = false;
            }
            else
            {
                btnAdminPaneel.Visible = kasutajaRoll == "Omanik" || kasutajaRoll == "Admin";
            }
        }

        private void RefreshEverything()
        {
            LoadCategories();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT t.Id, t.Toodenimetus, t.Kogus, t.Hind, t.Pilt, k.Kategooria_nimetus " +
                    "FROM Tooded t LEFT JOIN Kategooria k ON t.Kategooriad_ID = k.Id", connect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewTooded.DataSource = table;

                // Hide Id and raw Pilt columns
                if (dataGridViewTooded.Columns.Contains("Id"))
                    dataGridViewTooded.Columns["Id"].Visible = false;
                if (dataGridViewTooded.Columns.Contains("Pilt"))
                    dataGridViewTooded.Columns["Pilt"].Visible = false;

                // Load images into PiltImage column
                foreach (DataGridViewRow row in dataGridViewTooded.Rows)
                {
                    if (row.IsNewRow) continue;
                    string path = row.Cells["Pilt"].Value?.ToString() ?? "";
                    if (File.Exists(path))
                    {
                        try { row.Cells["PiltImage"].Value = Image.FromFile(path); }
                        catch { row.Cells["PiltImage"].Value = null; }
                    }
                    else
                    {
                        row.Cells["PiltImage"].Value = null;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Viga: " + ex.Message); }
        }

        private void LoadCategories()
        {
            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbKategooria.DataSource = dt;
                cmbKategooria.DisplayMember = "Kategooria_nimetus";
                cmbKategooria.ValueMember = "Id";
            }
            catch { }
        }

        private void btnOtsiPilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Images|*.jpg;*.png;*.jpeg" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                piltPath = ofd.FileName;
                try { picPilt.Image = Image.FromFile(piltPath); }
                catch { picPilt.Image = null; }
            }
        }

        private void btnLisa_Click(object sender, EventArgs e)
        {
            if (cmbKategooria.SelectedValue == null) { MessageBox.Show("Vali kategooria!"); return; }
            if (!int.TryParse(txtKogus.Text, out int kogus) || kogus < 0)
            { MessageBox.Show("Kogus peab olema mittenegatiivne täisarv!"); return; }
            if (!decimal.TryParse(txtHind.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal hind) || hind < 0)
            { MessageBox.Show("Hind peab olema mittenegatiivne!"); return; }

            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Tooded(Toodenimetus, Kogus, Hind, Pilt, Kategooriad_ID) VALUES(@n, @k, @h, @p, @kat)", connect);
                cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                cmd.Parameters.AddWithValue("@k", kogus);
                cmd.Parameters.AddWithValue("@h", hind);
                cmd.Parameters.AddWithValue("@p", piltPath);
                cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue);
                cmd.ExecuteNonQuery();
                connect.Close();
                RefreshEverything();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); if (connect.State == ConnectionState.Open) connect.Close(); }
        }

        private void btnUuenda_Click(object sender, EventArgs e)
        {
            if (dataGridViewTooded.SelectedRows.Count == 0) return;
            if (!int.TryParse(txtKogus.Text, out int kogus) || kogus < 0)
            { MessageBox.Show("Kogus peab olema mittenegatiivne täisarv!"); return; }
            if (!decimal.TryParse(txtHind.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal hind) || hind < 0)
            { MessageBox.Show("Hind peab olema mittenegatiivne!"); return; }

            try
            {
                int id = Convert.ToInt32(dataGridViewTooded.SelectedRows[0].Cells["Id"].Value);
                if (connect.State == ConnectionState.Open) connect.Close();
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Tooded SET Toodenimetus=@n, Kogus=@k, Hind=@h, Pilt=@p, Kategooriad_ID=@kat WHERE Id=@id", connect);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                cmd.Parameters.AddWithValue("@k", kogus);
                cmd.Parameters.AddWithValue("@h", hind);
                cmd.Parameters.AddWithValue("@p", piltPath);
                cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue);
                cmd.ExecuteNonQuery();
                connect.Close();
                RefreshEverything();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); if (connect.State == ConnectionState.Open) connect.Close(); }
        }

        private void btnKustuta_Click(object sender, EventArgs e)
        {
            if (dataGridViewTooded.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridViewTooded.SelectedRows[0].Cells["Id"].Value);
            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                connect.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Tooded WHERE Id=@id", connect);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connect.Close();
                RefreshEverything();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); if (connect.State == ConnectionState.Open) connect.Close(); }
        }

        private void btnLisaKat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUusKat.Text))
            {
                try
                {
                    if (connect.State == ConnectionState.Open) connect.Close();
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Kategooria(Kategooria_nimetus) VALUES(@n)", connect);
                    cmd.Parameters.AddWithValue("@n", txtUusKat.Text.Trim());
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    txtUusKat.Clear();
                    LoadCategories();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); if (connect.State == ConnectionState.Open) connect.Close(); }
            }
        }

        private void dataGridViewTooded_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridViewTooded.Rows[e.RowIndex];
            txtNimetus.Text = row.Cells["Toodenimetus"].Value?.ToString() ?? "";
            txtKogus.Text = row.Cells["Kogus"].Value?.ToString() ?? "";
            txtHind.Text = row.Cells["Hind"].Value?.ToString() ?? "";
            piltPath = row.Cells["Pilt"].Value?.ToString() ?? "";
            if (File.Exists(piltPath))
            {
                try { picPilt.Image = Image.FromFile(piltPath); }
                catch { picPilt.Image = null; }
            }
            else
            {
                picPilt.Image = null;
            }
        }

        private void btnAvaKassa_Click(object sender, EventArgs e)
        {
            new Kassa().Show();
        }

        private void btnAdminPaneel_Click(object sender, EventArgs e)
        {
            new AdminPanel().ShowDialog();
        }
    }
}
