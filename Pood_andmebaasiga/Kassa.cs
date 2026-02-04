using iTextSharp.text; // Для PDF
using iTextSharp.text.pdf; // Для PDF
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
// System.Drawing не пишем в using, если используем полные пути, чтобы не было конфликтов с iTextSharp

namespace Pood_andmebaasiga
{
    public partial class Kassa : Form
    {
        // Используем |DataDirectory|, чтобы база работала на любом ПК
        readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");

        public Kassa()
        {
            InitializeComponent();
        }

        private void Kassa_Load(object sender, EventArgs e)
        {
            LaadiKassaTooded();
            TekitaVisuaalneKassa();
        }

        private void LaadiKassaTooded()
        {
            try
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Toodenimetus, Kogus, Hind FROM Tooted", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridKassa.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }

        private void btnMuu_Click(object sender, EventArgs e)
        {
            if (dataGridKassa.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridKassa.CurrentRow.Cells["Id"].Value);
            int laos = Convert.ToInt32(dataGridKassa.CurrentRow.Cells["Kogus"].Value);
            int soovitud = (int)numKogus.Value;

            if (soovitud <= 0) { MessageBox.Show("Vali kogus!"); return; }
            if (soovitud > laos) { MessageBox.Show("Ei ole piisavalt kaupa laos!"); return; }

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Tooted SET Kogus = Kogus - @kogus WHERE Id = @id", connect);
                cmd.Parameters.AddWithValue("@kogus", soovitud);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connect.Close();

                LooTsekk();
                LaadiKassaTooded();
                TekitaVisuaalneKassa(); // Обновляем картинки, если товар кончился
                MessageBox.Show("Ost sooritatud!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); connect.Close(); }
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

            double hind = Convert.ToDouble(dataGridKassa.CurrentRow.Cells["Hind"].Value);
            double summa = hind * (double)numKogus.Value;

            doc.Add(new Paragraph($"Summa: {summa:F2} EUR"));
            doc.Close();
        }

        private void TekitaVisuaalneKassa()
        {
            flpTooted.Controls.Clear();
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Toodenimetus, Hind, Pilt FROM Tooted WHERE Kogus > 0", connect);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    GroupBox box = new GroupBox { Size = new System.Drawing.Size(150, 200), Text = dr["Toodenimetus"].ToString() };

                    PictureBox pic = new PictureBox
                    {
                        Size = new System.Drawing.Size(130, 100),
                        Location = new System.Drawing.Point(10, 20),
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    string pildiNimi = dr["Pilt"].ToString();
                    // Путь к папке bin/Debug/Images
                    string tee = Path.Combine(Application.StartupPath, "Images", pildiNimi);

                    if (File.Exists(tee))
                    {
                        pic.Image = System.Drawing.Image.FromFile(tee);
                    }

                    System.Windows.Forms.Label lbl = new System.Windows.Forms.Label
                    {
                        Text = dr["Hind"].ToString() + " €",
                        Location = new System.Drawing.Point(10, 130),
                        Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
                    };

                    System.Windows.Forms.Button btn = new System.Windows.Forms.Button
                    {
                        Text = "Vali",
                        Location = new System.Drawing.Point(10, 160),
                        Tag = dr["Id"]
                    };
                    btn.Click += OstuNupu_Click;

                    box.Controls.Add(pic);
                    box.Controls.Add(lbl);
                    box.Controls.Add(btn);
                    flpTooted.Controls.Add(box);
                }
            }
            catch (Exception ex) { MessageBox.Show("Viga piltide laadimisel: " + ex.Message); }
            finally { connect.Close(); }
        }

        private void OstuNupu_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            int tooteId = (int)btn.Tag;

            // Автоматически выбираем этот товар в DataGridView
            foreach (DataGridViewRow row in dataGridKassa.Rows)
            {
                if (Convert.ToInt32(row.Cells["Id"].Value) == tooteId)
                {
                    row.Selected = true;
                    dataGridKassa.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
    }
}