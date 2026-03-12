using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    public partial class Register : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegistreeri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNimi.Text))
            { MessageBox.Show("Sisesta kasutajanimi!"); return; }
            if (string.IsNullOrWhiteSpace(txtParool.Text))
            { MessageBox.Show("Sisesta parool!"); return; }

            string roll = cmbRoll.SelectedItem?.ToString() ?? "Müüja";

            try
            {
                if (connect.State == System.Data.ConnectionState.Open) connect.Close();
                connect.Open();
                SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Kasutajad WHERE Kasutajanimi=@n", connect);
                check.Parameters.AddWithValue("@n", txtNimi.Text.Trim());
                int count = (int)check.ExecuteScalar();
                if (count > 0)
                {
                    connect.Close();
                    MessageBox.Show("Kasutajanimi on juba kasutusel!");
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Kasutajad (Kasutajanimi, Parool, Roll) VALUES (@n, @p, @r)", connect);
                cmd.Parameters.AddWithValue("@n", txtNimi.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtParool.Text);
                cmd.Parameters.AddWithValue("@r", roll);
                cmd.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Kasutaja registreeritud!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga registreerimisel: " + ex.Message);
                if (connect.State == System.Data.ConnectionState.Open) connect.Close();
            }
        }

        private void btnTühista_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
