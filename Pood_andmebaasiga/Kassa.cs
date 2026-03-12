using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        DataTable allProductsTable = new DataTable();

        public Kassa()
        {
            InitializeComponent();
            // korvTable columns: Id, Toode, Hind, Kogus
            korvTable.Columns.Add("Id", typeof(int));
            korvTable.Columns.Add("Toode", typeof(string));
            korvTable.Columns.Add("Hind", typeof(decimal));
            korvTable.Columns.Add("Kogus", typeof(int));
            dataGridViewKorv.DataSource = korvTable;

            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT Id, Toodenimetus, Kogus, Hind, Pilt FROM Tooded WHERE Kogus > 0", connect);
                allProductsTable = new DataTable();
                adapter.Fill(allProductsTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga toodete laadimisel: " + ex.Message);
            }
            RenderProductCards(txtOtsing.Text);
        }

        private void RenderProductCards(string filter)
        {
            flowProducts.Controls.Clear();
            foreach (DataRow row in allProductsTable.Rows)
            {
                string name = row["Toodenimetus"].ToString();
                if (!string.IsNullOrEmpty(filter) &&
                    name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) < 0)
                    continue;

                int id = Convert.ToInt32(row["Id"]);
                decimal hind = Convert.ToDecimal(row["Hind"]);
                int kogus = Convert.ToInt32(row["Kogus"]);
                string piltPath = row["Pilt"].ToString();

                // Card panel
                Panel card = new Panel
                {
                    Size = new Size(160, 200),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Tag = row
                };

                PictureBox pic = new PictureBox
                {
                    Size = new Size(140, 120),
                    Location = new Point(10, 8),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.FromArgb(236, 240, 241)
                };
                if (File.Exists(piltPath))
                {
                    try { pic.Image = Image.FromFile(piltPath); }
                    catch { pic.Image = null; }
                }

                Label lblName = new Label
                {
                    Text = name,
                    Location = new Point(5, 132),
                    Size = new Size(150, 35),
                    Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label lblPrice = new Label
                {
                    Text = $"{hind:F2} €  (laos: {kogus})",
                    Location = new Point(5, 167),
                    Size = new Size(150, 22),
                    Font = new Font("Segoe UI", 8f),
                    ForeColor = Color.FromArgb(39, 174, 96),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                card.Controls.Add(pic);
                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);

                card.Click += (s, ev) => CardClicked(row);
                pic.Click += (s, ev) => CardClicked(row);
                lblName.Click += (s, ev) => CardClicked(row);
                lblPrice.Click += (s, ev) => CardClicked(row);

                flowProducts.Controls.Add(card);
            }
        }

        private void CardClicked(DataRow row)
        {
            int id = Convert.ToInt32(row["Id"]);
            string name = row["Toodenimetus"].ToString();
            decimal hind = Convert.ToDecimal(row["Hind"]);
            int kogus = Convert.ToInt32(row["Kogus"]);

            if (kogus <= 0)
            {
                MessageBox.Show("Kaup on otsas!");
                return;
            }

            // Check if already in cart
            bool found = false;
            foreach (DataRow cr in korvTable.Rows)
            {
                if (Convert.ToInt32(cr["Id"]) == id)
                {
                    cr["Kogus"] = Convert.ToInt32(cr["Kogus"]) + 1;
                    found = true;
                    break;
                }
            }
            if (!found)
                korvTable.Rows.Add(id, name, hind, 1);

            UpdateStock(id, -1);
            // Refresh local data
            row["Kogus"] = kogus - 1;
            RenderProductCards(txtOtsing.Text);
            UpdateKorvGrid();
        }

        private void btnLisaKorvi_Click(object sender, EventArgs e)
        {
            // No dataGridViewShop anymore — cards are used instead
            // This button kept for keyboard/accessibility: select last card via Enter
            // For now just show hint
            MessageBox.Show("Kliki kaardil toote lisamiseks korvi.");
        }

        private void UpdateStock(int id, int change)
        {
            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Tooded SET Kogus = Kogus + @change WHERE Id = @id", connect);
                cmd.Parameters.AddWithValue("@change", change);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga laovaru uuendamisel: " + ex.Message);
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }

        private void UpdateKorvGrid()
        {
            dataGridViewKorv.DataSource = null;
            dataGridViewKorv.DataSource = korvTable;
            if (dataGridViewKorv.Columns.Contains("Id"))
                dataGridViewKorv.Columns["Id"].Visible = false;
        }

        private void btnEemaldaKorvist_Click(object sender, EventArgs e)
        {
            if (dataGridViewKorv.SelectedRows.Count == 0) return;
            int idx = dataGridViewKorv.SelectedRows[0].Index;
            if (idx < 0 || idx >= korvTable.Rows.Count) return;
            DataRow row = korvTable.Rows[idx];
            int id = Convert.ToInt32(row["Id"]);
            int inCart = Convert.ToInt32(row["Kogus"]);
            UpdateStock(id, inCart); // return all to stock

            // Update local allProductsTable
            foreach (DataRow pr in allProductsTable.Rows)
            {
                if (Convert.ToInt32(pr["Id"]) == id)
                {
                    pr["Kogus"] = Convert.ToInt32(pr["Kogus"]) + inCart;
                    break;
                }
            }
            korvTable.Rows.RemoveAt(idx);
            RenderProductCards(txtOtsing.Text);
            UpdateKorvGrid();
        }

        private void txtOtsing_TextChanged(object sender, EventArgs e)
        {
            RenderProductCards(txtOtsing.Text);
        }

        private void txtKorvOtsing_TextChanged(object sender, EventArgs e)
        {
            string filter = txtKorvOtsing.Text.Trim();
            if (string.IsNullOrEmpty(filter))
            {
                dataGridViewKorv.DataSource = korvTable;
            }
            else
            {
                // Escape single quotes to prevent DataView RowFilter issues
                string safeFilter = filter.Replace("'", "''");
                DataView dv = new DataView(korvTable);
                dv.RowFilter = $"Toode LIKE '%{safeFilter}%'";
                dataGridViewKorv.DataSource = dv;
            }
            if (dataGridViewKorv.Columns.Contains("Id"))
                dataGridViewKorv.Columns["Id"].Visible = false;
        }

        private void btnOsta_Click(object sender, EventArgs e)
        {
            if (korvTable.Rows.Count == 0)
            {
                MessageBox.Show("Ostukorv on tühi!");
                return;
            }

            try
            {
                string arvedDir = Path.Combine(Application.StartupPath, "Arved");
                if (!Directory.Exists(arvedDir))
                    Directory.CreateDirectory(arvedDir);

                string fileName = Path.Combine(arvedDir,
                    $"arve_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                doc.Open();

                doc.Add(new Paragraph("OSTUTSEKK"));
                doc.Add(new Paragraph("Kuupäev: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")));
                doc.Add(new Paragraph("----------------------------------------"));

                decimal total = 0;
                foreach (DataRow r in korvTable.Rows)
                {
                    string toode = r["Toode"].ToString();
                    decimal hind = Convert.ToDecimal(r["Hind"]);
                    int qty = Convert.ToInt32(r["Kogus"]);
                    decimal lineTotal = hind * qty;
                    total += lineTotal;
                    doc.Add(new Paragraph($"{toode}  x{qty}  @ {hind:F2} €  = {lineTotal:F2} €"));
                }

                doc.Add(new Paragraph("----------------------------------------"));
                doc.Add(new Paragraph($"KOKKU: {total:F2} €"));
                doc.Close();

                System.Diagnostics.Process.Start(fileName);

                korvTable.Clear();
                UpdateKorvGrid();
                // Reload products from DB to get fresh stock
                allProductsTable.Clear();
                LoadProducts();
                MessageBox.Show("Ost sooritatud! Arve salvestatud: " + fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga PDF loomisel: " + ex.Message);
            }
        }
    }
}
