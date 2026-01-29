using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Pood_andmebaasiga
{
    public partial class Tooded : Form
    {
        readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Tooted_Pood_andmebaasiga\Pood_andmebaasiga\Tooded.mdf;Integrated Security=True");
        readonly string kasutajaRoll;

        public Tooded(string roll)
        {
            InitializeComponent();
            kasutajaRoll = roll;

            if (kasutajaRoll == "Müüja")
            {
                btnLisa.Enabled = btnUuenda.Enabled = btnKustuta.Enabled = false;
                btnLisaKategooria.Enabled = btnKustutaKategooria.Enabled = false;
            }
        }

        private void Tooded_Load(object sender, EventArgs e)
        {
            LaadiKategooriad();
            LaadiTooted();
        }

        private void LaadiKategooriad()
        {
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kategooriad", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            cmbKategooria.DataSource = dt;
            cmbKategooria.DisplayMember = "Nimetus";
            cmbKategooria.ValueMember = "Id";
        }

        private void LaadiTooted()
        {
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tooted", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            dataGridTooted.DataSource = dt;
        }

        private void btnLisa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNimetus.Text)) return;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tooted (Toodenimetus, Kogus, Hind, Kategooria_Id, Pilt) VALUES (@n, @k, @h, @kat, @p)", connect);
                cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                cmd.Parameters.AddWithValue("@k", int.Parse(txtKogus.Text));
                cmd.Parameters.AddWithValue("@h", decimal.Parse(txtHind.Text.Replace('.', ',')));
                cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue);
                cmd.Parameters.AddWithValue("@p", picPilt.ImageLocation != null ? Path.GetFileName(picPilt.ImageLocation) : "noimage.png");
                cmd.ExecuteNonQuery();
                connect.Close();
                LaadiTooted();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); connect.Close(); }
        }

        private void btnUuenda_Click(object sender, EventArgs e)
        {
            if (dataGridTooted.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridTooted.CurrentRow.Cells["Id"].Value);
            connect.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Tooted SET Toodenimetus=@n, Kogus=@k, Hind=@h, Kategooria_Id=@kat WHERE Id=@id", connect);
            cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
            cmd.Parameters.AddWithValue("@k", txtKogus.Text);
            cmd.Parameters.AddWithValue("@h", txtHind.Text.Replace('.', ','));
            cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connect.Close();
            LaadiTooted();
        }

        private void btnKustuta_Click(object sender, EventArgs e)
        {
            if (dataGridTooted.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridTooted.CurrentRow.Cells["Id"].Value);
            connect.Open();
            new SqlCommand($"DELETE FROM Tooted WHERE Id={id}", connect).ExecuteNonQuery();
            connect.Close();
            LaadiTooted();
        }

        private void dataGridTooted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dataGridTooted.Rows[e.RowIndex];
            txtNimetus.Text = r.Cells["Toodenimetus"].Value.ToString();
            txtKogus.Text = r.Cells["Kogus"].Value.ToString();
            txtHind.Text = r.Cells["Hind"].Value.ToString();
            cmbKategooria.SelectedValue = r.Cells["Kategooria_Id"].Value;
        }

        private void btnOtsiPilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog { Filter = "Images|*.jpg;*.png" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                picPilt.Image = Image.FromFile(open.FileName);
                picPilt.ImageLocation = open.FileName;
                string imgDir = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(imgDir)) Directory.CreateDirectory(imgDir);
                string target = Path.Combine(imgDir, Path.GetFileName(open.FileName));
                if (!File.Exists(target)) File.Copy(open.FileName, target);
            }
        }

        private void btnLisaKategooria_Click(object sender, EventArgs e)
        {
            string nimi = Microsoft.VisualBasic.Interaction.InputBox("Nimi:", "Uus kategooria");
            if (!string.IsNullOrEmpty(nimi))
            {
                connect.Open();
                new SqlCommand($"INSERT INTO Kategooriad (Nimetus) VALUES ('{nimi}')", connect).ExecuteNonQuery();
                connect.Close();
                LaadiKategooriad();
            }
        }

        private void btnKustutaKategooria_Click(object sender, EventArgs e)
        {
            if (cmbKategooria.SelectedValue == null) return;
            connect.Open();
            new SqlCommand($"DELETE FROM Kategooriad WHERE Id={cmbKategooria.SelectedValue}", connect).ExecuteNonQuery();
            connect.Close();
            LaadiKategooriad();
        }

        private void btnAvaKassa_Click(object sender, EventArgs e)
        {
            new Kassa().Show();
        }
    }
}