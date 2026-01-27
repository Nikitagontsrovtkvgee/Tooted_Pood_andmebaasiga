using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    public partial class Login : Form
    {
        readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogiSisse_Click(object sender, EventArgs e)
        {
            // Kontrollime, et väljad poleks tühjad
            if (string.IsNullOrEmpty(txtKasutaja.Text) || string.IsNullOrEmpty(txtParool.Text))
            {
                MessageBox.Show("Sisesta kasutajanimi ja parool!");
                return;
            }

            connect.Open();
            // Otsime kasutajat andmebaasist
            SqlCommand cmd = new SqlCommand("SELECT Roll FROM Kasutajad WHERE Kasutajanimi=@nimi AND Parool=@parool", connect);
            cmd.Parameters.AddWithValue("@nimi", txtKasutaja.Text);
            cmd.Parameters.AddWithValue("@parool", txtParool.Text);

            object result = cmd.ExecuteScalar(); // Võtame rolli väärtuse
            connect.Close();

            if (result != null)
            {
                string roll = result.ToString();
                MessageBox.Show("Tere tulemast, " + roll + "!");

                // Avame peavormi ja saadame rolli kaasa
                Tooded peavorm = new Tooded(roll);
                peavorm.Show();
                this.Hide(); // Peidame sisselogimisakna
            }
            else
            {
                MessageBox.Show("Vale kasutajanimi või parool!");
            }
        }
    }
}
