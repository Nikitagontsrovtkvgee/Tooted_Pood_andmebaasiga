using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogiSisse_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT Roll FROM Kasutajad WHERE Kasutajanimi=@nimi AND Parool=@parool", connect);
                cmd.Parameters.AddWithValue("@nimi", txtKasutaja.Text.Trim());
                cmd.Parameters.AddWithValue("@parool", txtParool.Text);

                object result = cmd.ExecuteScalar();
                connect.Close();

                if (result != null)
                {
                    string roll = result.ToString();
                    MessageBox.Show("Tere tulemast! Roll: " + roll);

                    if (roll == "Omanik" || roll == "Admin")
                    {
                        new Tooded(roll).Show();
                        new Kassa().Show();
                    }
                    else if (roll == "Müüja")
                    {
                        new Kassa().Show();
                    }
                    else
                    {
                        MessageBox.Show("Tundmatu roll: " + roll);
                        return;
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vale kasutajanimi või parool!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga sisselogimisel: " + ex.Message);
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }

        private void btnRegistreeri_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }
    }
}
