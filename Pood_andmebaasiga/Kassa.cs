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
            // Выбираем данные, включая путь к картинке (Pilt)
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Toodenimetus, Hind, Pilt FROM Tooded", connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewKassa.DataSource = dt;
        }

        private void btnOsta_Click(object sender, EventArgs e)
        {
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
