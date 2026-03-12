using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    public partial class Kliendid : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");

        public Kliendid()
        {
            InitializeComponent();
            LoadKliendid();
        }

        private void LoadKliendid()
        {
            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT Id, Nimi, Kliendikaart, Boonus FROM Kliendid", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewKliendid.DataSource = dt;
                if (dataGridViewKliendid.Columns.Contains("Id"))
                    dataGridViewKliendid.Columns["Id"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Viga klientide laadimisel: " + ex.Message); }
        }

        private void btnLisaKlient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNimi.Text))
            { MessageBox.Show("Sisesta kliendi nimi!"); return; }

            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Kliendid (Nimi, Kliendikaart, Boonus) VALUES (@n, @k, @b)", connect);
                cmd.Parameters.AddWithValue("@n", txtNimi.Text.Trim());
                cmd.Parameters.AddWithValue("@k", txtKliendikaart.Text.Trim());
                cmd.Parameters.AddWithValue("@b", 0);
                cmd.ExecuteNonQuery();
                connect.Close();
                txtNimi.Clear();
                txtKliendikaart.Clear();
                LoadKliendid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga kliendi lisamisel: " + ex.Message);
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }

        private void btnKustutaKlient_Click(object sender, EventArgs e)
        {
            if (dataGridViewKliendid.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridViewKliendid.SelectedRows[0].Cells["Id"].Value);
            if (MessageBox.Show("Kustuta klient?", "Kinnitus",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (connect.State == ConnectionState.Open) connect.Close();
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Kliendid WHERE Id=@id", connect);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    LoadKliendid();
                }
                catch (Exception ex) { MessageBox.Show("Viga: " + ex.Message); if (connect.State == ConnectionState.Open) connect.Close(); }
            }
        }
    }
}
