using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Pood_andmebaasiga
{
    public partial class Tooded : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");
        string kasutajaRoll;

        public Tooded(string roll)
        {
            InitializeComponent();
            kasutajaRoll = roll;
            if (kasutajaRoll == "Müüja")
            {
                btnLisa.Enabled = btnUuenda.Enabled = btnKustuta.Enabled = false;
                btnLisaKategooria.Enabled = btnKustutaKategooria.Enabled = false;
            }
        }

        private void Tooded_Load(object sender, EventArgs e)
        {
            LaadiKategooriad();
            LaadiTooded();
        }

        private void LaadiKategooriad()
        {
            try
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbKategooria.DataSource = null; // Очистка дублей
                cmbKategooria.DataSource = dt;
                cmbKategooria.DisplayMember = "Kategooria_nimetus";
                cmbKategooria.ValueMember = "Id";
            }
            catch (Exception ex) { MessageBox.Show("Viga: " + ex.Message); }
            finally { connect.Close(); }
        }

        private void LaadiTooded()
        {
            try
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tooded", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridTooted.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Viga: " + ex.Message); }
            finally { connect.Close(); }
        }

        private void btnLisa_Click(object sender, EventArgs e)
        {
            if (txtNimetus.Text != "" && txtKogus.Text != "" && txtHind.Text != "")
            {
                try
                {
                    connect.Open();
                    // Исправлено: добавлены все нужные параметры и правильное имя таблицы Tooded
                    SqlCommand cmd = new SqlCommand("INSERT INTO Tooded(Toodenimetus, Kogus, Hind, Pilt, Kategooriad_ID) VALUES(@n, @k, @h, @p, @kat)", connect);
                    cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                    cmd.Parameters.AddWithValue("@k", int.Parse(txtKogus.Text));
                    cmd.Parameters.AddWithValue("@h", decimal.Parse(txtHind.Text.Replace('.', ',')));
                    cmd.Parameters.AddWithValue("@p", Path.GetFileName(picPilt.ImageLocation) ?? "noimage.png");
                    cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                    connect.Close();
                    LaadiTooded();
                }
                catch (Exception ex) { MessageBox.Show("Viga добавления: " + ex.Message); connect.Close(); }
            }
        }

        private void dataGridTooted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridTooted.Rows[e.RowIndex];
                txtNimetus.Text = r.Cells["Toodenimetus"].Value.ToString();
                txtKogus.Text = r.Cells["Kogus"].Value.ToString();
                txtHind.Text = r.Cells["Hind"].Value.ToString();
                if (r.Cells["Kategooriad_ID"].Value != DBNull.Value)
                {
                    cmbKategooria.SelectedValue = r.Cells["Kategooriad_ID"].Value;
                }
            }
        }

        private void btnOtsiPilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picPilt.Image = Image.FromFile(ofd.FileName);
                picPilt.ImageLocation = ofd.FileName;
            }
        }

        private void btnUuenda_Click(object sender, EventArgs e)
        {
            if (dataGridTooted.CurrentRow != null)
            {
                try
                {
                    connect.Open();
                    // Исправлено: добавлен @kat, которого не хватало на твоем скриншоте
                    SqlCommand cmd = new SqlCommand("UPDATE Tooded SET Toodenimetus=@n, Kogus=@k, Hind=@h, Pilt=@p, Kategooriad_ID=@kat WHERE Id=@id", connect);
                    cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                    cmd.Parameters.AddWithValue("@k", txtKogus.Text);
                    cmd.Parameters.AddWithValue("@h", txtHind.Text.Replace('.', ','));
                    cmd.Parameters.AddWithValue("@p", Path.GetFileName(picPilt.ImageLocation) ?? "noimage.png");
                    cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", dataGridTooted.CurrentRow.Cells["Id"].Value);

                    cmd.ExecuteNonQuery();
                    connect.Close();
                    LaadiTooded();
                }
                catch (Exception ex) { MessageBox.Show("Viga обновления: " + ex.Message); connect.Close(); }
            }
        }

        private void btnKustuta_Click(object sender, EventArgs e)
        {
            if (dataGridTooted.SelectedRows.Count > 0)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Tooded WHERE Id=@id", connect);
                    cmd.Parameters.AddWithValue("@id", dataGridTooted.SelectedRows[0].Cells["Id"].Value);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    LaadiTooded();
                }
                catch (Exception ex) { MessageBox.Show("Viga удаления: " + ex.Message); connect.Close(); }
            }
        }

        private void btnLisaKategooria_Click(object sender, EventArgs e)
        {
            string nimi = Microsoft.VisualBasic.Interaction.InputBox("Sisesta kategooria nimi", "Uus");
            if (!string.IsNullOrWhiteSpace(nimi))
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Kategooria(Kategooria_nimetus) VALUES(@kat)", connect);
                    cmd.Parameters.AddWithValue("@kat", nimi);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    LaadiKategooriad();
                }
                catch (Exception ex) { MessageBox.Show("Viga категории: " + ex.Message); connect.Close(); }
            }
        }

        private void btnKustutaKategooria_Click(object sender, EventArgs e)
        {
            if (cmbKategooria.SelectedValue != null)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Kategooria WHERE Id=@id", connect);
                    cmd.Parameters.AddWithValue("@id", cmbKategooria.SelectedValue);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    LaadiKategooriad();
                }
                catch (Exception ex) { MessageBox.Show("Viga удаления категории: " + ex.Message); connect.Close(); }
            }
        }
    }
}