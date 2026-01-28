using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Pood_andmebaasiga
{
    public partial class Tooded : Form
    {
        readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\OPILANE\SOURCE\REPOS\TOOTED_POOD_ANDMEBAASIGA\POOD_ANDMEBAASIGA\TOOTED.MDF;Integrated Security=True");
        private void LaadiKategooriad()
        {
            // Avab ühenduse andmebaasiga
            connect.Open();

            // Võtab kõik kategooriad tabelist
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Kategooriad", connect);

            DataTable dt = new DataTable();
            da.Fill(dt);

            // Sulgeb ühenduse
            connect.Close();

            // Täidab ComboBoxi andmetega
            cmbKategooria.DataSource = dt;
            cmbKategooria.DisplayMember = "Nimetus"; // Näidatav tekst
            cmbKategooria.ValueMember = "Id";        // Tegelik väärtus
        }
        private void LaadiTooted()
        {
            // Avab ühenduse
            connect.Open();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Tooted", connect);

            DataTable dt = new DataTable();
            da.Fill(dt);

            // Sulgeb ühenduse
            connect.Close();

            // Kuvab tabelis
            dataGridTooted.DataSource = dt;
        }
        string kasutajaRoll;
        public Tooded(string roll)
        {
            InitializeComponent();
            kasutajaRoll = roll;

            // Kontrollime rolli ja piirame ligipääsu
            if (kasutajaRoll == "Müüja")
            {
                // Müüja ei saa tooteid lisada, muuta ega kustutada
                btnLisa.Enabled = false;
                btnUuenda.Enabled = false;
                btnKustuta.Enabled = false;
                btnLisaKategooria.Enabled = false;
                btnKustutaKategooria.Enabled = false;

                // Võid ka peita nupud: btnLisa.Visible = false;
            }
        }

        private void Tooded_Load(object sender, EventArgs e)
        {
            LaadiKategooriad();
            LaadiTooted();
        }
        private void btnUuenda_Click(object sender, EventArgs e)
        {
            // Kontrollime, kas rida on valitud
            if (dataGridTooted.CurrentRow == null)
            {
                MessageBox.Show("Vali rida, mida soovid uuendada!");
                return;
            }

            int id = Convert.ToInt32(dataGridTooted.CurrentRow.Cells["Id"].Value);

            // Kontrollime sisestust (sisestuskontroll)
            if (!int.TryParse(txtKogus.Text, out int kogus) || kogus < 0 ||
                !decimal.TryParse(txtHind.Text, out decimal hind) || hind < 0)
            {
                MessageBox.Show("Sisesta korrektne kogus ja hind!");
                return;
            }

            // Pildi uuendamine
            string pilt = picPilt.ImageLocation != null ? Path.GetFileName(picPilt.ImageLocation) : dataGridTooted.CurrentRow.Cells["Pilt"].Value.ToString();

            connect.Open();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Tooted SET Toodenimetus=@n, Kogus=@k, Hind=@h, Pilt=@p, Kategooria_Id=@kat WHERE Id=@id", connect);

            cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
            cmd.Parameters.AddWithValue("@k", kogus);
            cmd.Parameters.AddWithValue("@h", hind);
            cmd.Parameters.AddWithValue("@p", pilt);
            cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Andmed on uuendatud!");
            LaadiTooted();
        }
        private void btnKustuta_Click(object sender, EventArgs e)
        {
            if (dataGridTooted.CurrentRow == null) return;

            DialogResult result = MessageBox.Show("Kas oled kindel, et soovid toote kustutada?", "Kustutamine", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridTooted.CurrentRow.Cells["Id"].Value);

                connect.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Tooted WHERE Id=@id", connect);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connect.Close();

                LaadiTooted();
                MessageBox.Show("Toode on eemaldatud.");
            }
        }
        private void dataGridTooted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow rida = dataGridTooted.Rows[e.RowIndex];
            txtNimetus.Text = rida.Cells["Toodenimetus"].Value.ToString();
            txtKogus.Text = rida.Cells["Kogus"].Value.ToString();
            txtHind.Text = rida.Cells["Hind"].Value.ToString();
            cmbKategooria.SelectedValue = rida.Cells["Kategooria_Id"].Value;

            // Näitame pilti Images kaustast
            string failiNimi = rida.Cells["Pilt"].Value.ToString();
            string pildiTee = Path.Combine(Application.StartupPath, "Images", failiNimi);

            if (File.Exists(pildiTee))
            {
                picPilt.Image = Image.FromFile(pildiTee);
            }
            else
            {
                picPilt.Image = null; // Või pane mingi placeholder pilt
            }
        }

    }
}