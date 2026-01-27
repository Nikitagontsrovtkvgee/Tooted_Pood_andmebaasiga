using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    public partial class Kassa : Form
    {
        public Kassa()
        {
            InitializeComponent();
        }
        // Ühendusstring (sama mis Tooded vormis)
        readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");

        // Funktsioon toodete laadimiseks kassasse
        private void LaadiKassaTooded()
        {
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Toodenimetus, Kogus, Hind FROM Tooted", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            dataGridKassa.DataSource = dt;
        }

        // Ostu sooritamine ja andmebaasi uuendamine
        private void btnMuu_Click(object sender, EventArgs e)
        {
            if (dataGridKassa.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridKassa.CurrentRow.Cells["Id"].Value);
            int laos = Convert.ToInt32(dataGridKassa.CurrentRow.Cells["Kogus"].Value);
            int soovitud = (int)numKogus.Value;

            if (soovitud > laos)
            {
                MessageBox.Show("Ei ole piisavalt kaupa laos!");
                return;
            }

            // Vähendame kogust andmebaasis
            connect.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Tooted SET Kogus = Kogus - @kogus WHERE Id = @id", connect);
            cmd.Parameters.AddWithValue("@kogus", soovitud);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connect.Close();

            LooTsekk(); // Kutsume tšeki loomise funktsiooni
            LaadiKassaTooded(); // Uuendame tabelit
            MessageBox.Show("Ost sooritatud!");
        }
        private void LooTsekk()
        {
            string kataloog = Path.Combine(Application.StartupPath, "Arved");
            if (!Directory.Exists(kataloog)) Directory.CreateDirectory(kataloog);

            string failiNimi = Path.Combine(kataloog, $"Tsekk_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(failiNimi, FileMode.Create));

            doc.Open();
            doc.Add(new Paragraph("KAUPLUSE TSEKK"));
            doc.Add(new Paragraph($"Kuupaev: {DateTime.Now}"));
            doc.Add(new Paragraph("----------------------------"));
            doc.Add(new Paragraph($"Toode: {dataGridKassa.CurrentRow.Cells["Toodenimetus"].Value}"));
            doc.Add(new Paragraph($"Kogus: {numKogus.Value}"));
            doc.Add(new Paragraph($"Summa: {Convert.ToDouble(dataGridKassa.CurrentRow.Cells["Hind"].Value) * (double)numKogus.Value} EUR"));
            doc.Close();
        }
    }
}
