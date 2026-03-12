using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    public partial class AdminPanel : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");

        public AdminPanel()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT Id, Kasutajanimi, Roll FROM Kasutajad", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUsers.DataSource = dt;
                if (dataGridViewUsers.Columns.Contains("Id"))
                    dataGridViewUsers.Columns["Id"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Viga: " + ex.Message); }
        }

        private void btnKustutaKasutaja_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);
            if (MessageBox.Show("Kustuta kasutaja?", "Kinnitus",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (connect.State == ConnectionState.Open) connect.Close();
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Kasutajad WHERE Id=@id", connect);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    LoadUsers();
                }
                catch (Exception ex) { MessageBox.Show("Viga: " + ex.Message); if (connect.State == ConnectionState.Open) connect.Close(); }
            }
        }

        private void btnAvaKliendid_Click(object sender, EventArgs e)
        {
            new Kliendid().ShowDialog();
        }
    }
}
