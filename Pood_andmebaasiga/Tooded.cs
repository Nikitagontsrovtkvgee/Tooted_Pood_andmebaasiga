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
        SqlConnection connect = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");
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

        public Tooded()
        {
            InitializeComponent();
        }
    }
}