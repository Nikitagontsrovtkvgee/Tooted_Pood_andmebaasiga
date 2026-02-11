using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Pood_andmebaasiga
{
    public partial class Kassa : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");

        public Kassa()
        {
            InitializeComponent();
            LoadKassaData();
        }

        private void LoadKassaData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Toodenimetus, Hind FROM Tooded", connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewKassa.DataSource = dt;
        }

        private void btnOsta_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(Application.StartupPath, "tsekk.pdf");
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph("OSTUTSEKK\n" + DateTime.Now));
            if (dataGridViewKassa.SelectedRows.Count > 0)
                doc.Add(new Paragraph("Toode: " + dataGridViewKassa.SelectedRows[0].Cells["Toodenimetus"].Value));
            doc.Close();
            MessageBox.Show("Tšekk salvestatud: " + file);
        }
    }
}