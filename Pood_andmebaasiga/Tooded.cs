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
        // Проверь путь к базе, если он другой — поправь
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");
        string piltPath = "";

        public Tooded(string roll)
        {
            InitializeComponent();
            RefreshEverything();
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT t.Id, t.Toodenimetus, t.Kogus, t.Hind, t.Pilt, k.Kategooria_nimetus FROM Tooded t LEFT JOIN Kategooria k ON t.Kategooriad_ID = k.Id", connect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewTooded.DataSource = table;
            }
            catch (Exception ex) { MessageBox.Show("Viga: " + ex.Message); }
        }

        private void LoadCategories()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbKategooria.DataSource = dt;
                cmbKategooria.DisplayMember = "Kategooria_nimetus";
                cmbKategooria.ValueMember = "Id";
                cmbKategooria.SelectedIndex = -1;
            }
            catch { }
        }

        private void btnOtsiPilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                piltPath = ofd.FileName;
                picPilt.Image = Image.FromFile(piltPath);
            }
        }

        private void btnLisa_Click(object sender, EventArgs e)
        {
            if (cmbKategooria.SelectedValue == null) { MessageBox.Show("Vali kategooria!"); return; }
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tooded(Toodenimetus, Kogus, Hind, Pilt, Kategooriad_ID) VALUES(@n, @k, @h, @p, @kat)", connect);
                cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                cmd.Parameters.AddWithValue("@k", txtKogus.Text);
                cmd.Parameters.AddWithValue("@h", txtHind.Text.Replace(',', '.'));
                cmd.Parameters.AddWithValue("@p", piltPath);
                cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue);
                cmd.ExecuteNonQuery();
                connect.Close();
                RefreshEverything();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); connect.Close(); }
        }

        private void btnUuenda_Click(object sender, EventArgs e)
        {
            if (dataGridViewTooded.SelectedRows.Count > 0 && cmbKategooria.SelectedValue != null)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridViewTooded.SelectedRows[0].Cells["Id"].Value);
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Tooded SET Toodenimetus=@n, Kogus=@k, Hind=@h, Pilt=@p, Kategooriad_ID=@kat WHERE Id=@id", connect);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                    cmd.Parameters.AddWithValue("@k", txtKogus.Text);
                    cmd.Parameters.AddWithValue("@h", txtHind.Text.Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@p", piltPath);
                    cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    RefreshEverything();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); connect.Close(); }
            }
        }

        private void btnKustuta_Click(object sender, EventArgs e)
        {
            if (dataGridViewTooded.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewTooded.SelectedRows[0].Cells["Id"].Value);
                connect.Open();
                new SqlCommand($"DELETE FROM Tooded WHERE Id={id}", connect).ExecuteNonQuery();
                connect.Close();
                RefreshEverything();
            }
        }

        private void btnLisaKat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUusKat.Text))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kategooria(Kategooria_nimetus) VALUES(@n)", connect);
                cmd.Parameters.AddWithValue("@n", txtUusKat.Text);
                cmd.ExecuteNonQuery();
                connect.Close();
                txtUusKat.Clear();
                LoadCategories();
            }
        }

        private void dataGridViewTooded_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNimetus.Text = dataGridViewTooded.Rows[e.RowIndex].Cells["Toodenimetus"].Value.ToString();
                txtKogus.Text = dataGridViewTooded.Rows[e.RowIndex].Cells["Kogus"].Value.ToString();
                txtHind.Text = dataGridViewTooded.Rows[e.RowIndex].Cells["Hind"].Value.ToString();

                piltPath = dataGridViewTooded.Rows[e.RowIndex].Cells["Pilt"].Value.ToString();
                if (File.Exists(piltPath)) picPilt.Image = Image.FromFile(piltPath);
                else picPilt.Image = null;
            }
        }

        private void btnAvaKassa_Click(object sender, EventArgs e)
        {
            Kassa kassaVorm = new Kassa();
            kassaVorm.Show();
        }
    }
}
