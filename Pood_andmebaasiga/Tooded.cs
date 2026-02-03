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
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Tooted_Pood_andmebaasiga\Pood_andmebaasiga\Tooded.mdf;Integrated Security=True");
        string kasutajaRoll;

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
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nimetus FROM Kategooriad", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKategooria.DataSource = dt;
            cmbKategooria.DisplayMember = "Nimetus";
            cmbKategooria.ValueMember = "Id";
            connect.Close();
        }

        private void LaadiTooted()
        {
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tooted", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridTooted.DataSource = dt;
            connect.Close();
        }

        private void btnLisa_Click(object sender, EventArgs e)
        {
            if (txtNimetus.Text != "" && txtKogus.Text != "" && txtHind.Text != "")
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Tooted(Toodenimetus, Kogus, Hind, Pilt) VALUES(@n, @k, @h, @p)", connect);
                    cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                    cmd.Parameters.AddWithValue("@k", int.Parse(txtKogus.Text));
                    cmd.Parameters.AddWithValue("@h", decimal.Parse(txtHind.Text.Replace('.', ',')));
                    cmd.Parameters.AddWithValue("@p", Path.GetFileName(picPilt.ImageLocation) ?? "noimage.png");
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    LaadiTooted();
                }
                catch (Exception ex) { MessageBox.Show("Viga: " + ex.Message); connect.Close(); }
            }
        }

        private void dataGridTooted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridTooted.Rows[e.RowIndex];
                txtNimetus.Text = r.Cells["Toodenimetus"].Value.ToString();
                txtKogus.Text = r.Cells["Kogus"].Value.ToString();
                txtHind.Text = r.Cells["Hind"].Value.ToString();
                // Так как Kategooria_Id нет, просто обнуляем выбор или оставляем как есть
            }
        }

        private void btnOtsiPilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picPilt.Image = Image.FromFile(ofd.FileName);
                    picPilt.ImageLocation = ofd.FileName;
                }
                catch (Exception) { MessageBox.Show("Pildi viga"); }
            }
        }

        private void btnUuenda_Click(object sender, EventArgs e)
        {
            if (dataGridTooted.CurrentRow != null)
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Tooted SET Toodenimetus=@n, Kogus=@k, Hind=@h WHERE Id=@id", connect);
                cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                cmd.Parameters.AddWithValue("@k", txtKogus.Text);
                cmd.Parameters.AddWithValue("@h", txtHind.Text.Replace('.', ','));
                cmd.Parameters.AddWithValue("@id", dataGridTooted.CurrentRow.Cells["Id"].Value);
                cmd.ExecuteNonQuery();
                connect.Close();
                LaadiTooted();
            }
        }

        private void btnKustuta_Click(object sender, EventArgs e)
        {
            if (dataGridTooted.CurrentRow != null)
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Tooted WHERE Id=@id", connect);
                cmd.Parameters.AddWithValue("@id", dataGridTooted.CurrentRow.Cells["Id"].Value);
                cmd.ExecuteNonQuery();
                connect.Close();
                LaadiTooted();
            }
        }

        private void btnLisaKategooria_Click(object sender, EventArgs e)
        {
            string nimi = Microsoft.VisualBasic.Interaction.InputBox("Sisesta kategooria nimi", "Uus");
            if (nimi != "")
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kategooriad(Nimetus) VALUES(@n)", connect);
                cmd.Parameters.AddWithValue("@n", nimi);
                cmd.ExecuteNonQuery();
                connect.Close();
                LaadiKategooriad();
            }
        }

        private void btnKustutaKategooria_Click(object sender, EventArgs e)
        {
            if (cmbKategooria.SelectedValue != null)
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Kategooriad WHERE Id=@id", connect);
                cmd.Parameters.AddWithValue("@id", cmbKategooria.SelectedValue);
                cmd.ExecuteNonQuery();
                connect.Close();
                LaadiKategooriad();
            }
        }
    }
}