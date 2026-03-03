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
        DataTable korvTable = new DataTable();

        public Kassa()
        {
            InitializeComponent();
            korvTable.Columns.Add("Id", typeof(int));
            korvTable.Columns.Add("Toode");
            korvTable.Columns.Add("Hind", typeof(double));
            dataGridViewKorv.DataSource = korvTable;
            LoadShop();
        }

        private void LoadShop()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Toodenimetus, Kogus, Hind FROM Tooded", connect);
            // Выбираем данные, включая путь к картинке (Pilt)
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Toodenimetus, Hind, Pilt FROM Tooded", connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewShop.DataSource = dt;
            dataGridViewShop.Columns["Id"].Visible = false;
        }

        private void btnLisaKorvi_Click(object sender, EventArgs e)
        {
            if (dataGridViewShop.SelectedRows.Count > 0)
            {
                var row = dataGridViewShop.SelectedRows[0];
                int id = (int)row.Cells["Id"].Value;
                int laos = (int)row.Cells["Kogus"].Value;
                if (laos > 0)
                {
                    korvTable.Rows.Add(id, row.Cells["Toodenimetus"].Value, row.Cells["Hind"].Value);
                    UpdateStock(id, -1);
                    LoadShop();
                }
            }
        }

        private void UpdateStock(int id, int change)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Tooded SET Kogus = Kogus + @change WHERE Id = @id", connect);
            cmd.Parameters.AddWithValue("@change", change);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        private void btnOsta_Click(object sender, EventArgs e)
        {
            if (korvTable.Rows.Count == 0) return;
            Document doc = new Document();
            string path = Path.Combine(Application.StartupPath, "tsekk.pdf");
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph("TSEKK - " + DateTime.Now));
            double sum = 0;
            foreach (DataRow r in korvTable.Rows)
            {
                doc.Add(new Paragraph($"{r["Toode"]} - {r["Hind"]} EUR"));
                sum += Convert.ToDouble(r["Hind"]);
            }
            doc.Add(new Paragraph("KOKKU: " + sum + " EUR"));
            doc.Close();
            System.Diagnostics.Process.Start(path);
            korvTable.Clear();
            if (dataGridViewKassa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vali toode tabelist!");
                return;
            }

            try
            {
                // 1. Создаем файл чека
                string fileName = Path.Combine(Application.StartupPath, "tsekk.pdf");
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));

                doc.Open();

                // 2. Заголовок и Дата
                doc.Add(new Paragraph("OSTUTSEKK"));
                doc.Add(new Paragraph("Kuupäev: " + DateTime.Now.ToString()));
                doc.Add(new Paragraph("----------------------------------------"));

                // 3. Данные о товаре из выбранной строки
                string nimi = dataGridViewKassa.SelectedRows[0].Cells["Toodenimetus"].Value.ToString();
                string hind = dataGridViewKassa.SelectedRows[0].Cells["Hind"].Value.ToString();
                string piltPath = dataGridViewKassa.SelectedRows[0].Cells["Pilt"].Value.ToString();

                doc.Add(new Paragraph($"Toode: {nimi}"));
                doc.Add(new Paragraph($"Hind: {hind} EUR"));

                // 4. ВСТАВКА КАРТИНКИ В ЧЕК
                if (!string.IsNullOrEmpty(piltPath) && File.Exists(piltPath))
                {
                    iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(piltPath);
                    pdfImage.ScaleToFit(150f, 150f); // Ограничиваем размер картинки в чеке
                    pdfImage.Alignment = Element.ALIGN_LEFT;
                    doc.Add(pdfImage);
                }
                else
                {
                    doc.Add(new Paragraph("(Pilt puudub)"));
                }

                doc.Close();

                MessageBox.Show("Tšekk on valmis: " + fileName);
                // Автоматически открыть PDF после создания (по желанию)
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga PDF loomisel: " + ex.Message);
            }
        }
    }
}