using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    public partial class Tooded : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");
        string piltNimi = "pilt.png";

        public Tooded(string roll)
        {
            InitializeComponent();
            RefreshEverything();
        }

        private void RefreshEverything()
        {
            LoadCategories();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT t.Id, t.Toodenimetus, t.Kogus, t.Hind, t.Pilt, k.Kategooria_nimetus FROM Tooded t LEFT JOIN Kategooria k ON t.Kategooriad_ID = k.Id", connect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewTooded.DataSource = table;
            }
            catch (Exception ex) { MessageBox.Show("Andmete viga: " + ex.Message); }
        }

        private void LoadCategories()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbKategooria.DataSource = dt;
                cmbKategooria.DisplayMember = "Kategooria_nimetus";
                cmbKategooria.ValueMember = "Id";
                cmbKategooria.SelectedIndex = -1;
            }
            catch { }
        }

        private void btnLisa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNimetus.Text) || cmbKategooria.SelectedValue == null)
            {
                MessageBox.Show("Vali kategooria и sisesta nimi!"); return;
            }
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tooded(Toodenimetus, Kogus, Hind, Pilt, Kategooriad_ID) VALUES(@n, @k, @h, @p, @kat)", connect);
                cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                cmd.Parameters.AddWithValue("@k", txtKogus.Text);
                cmd.Parameters.AddWithValue("@h", txtHind.Text.Replace(',', '.'));
                cmd.Parameters.AddWithValue("@p", piltNimi);
                cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue);
                cmd.ExecuteNonQuery();
                connect.Close();
                RefreshEverything();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); connect.Close(); }
        }

        private void btnLisaKat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUusKat.Text))
            { // Используем отдельное поле!
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kategooria(Kategooria_nimetus) VALUES(@n)", connect);
                cmd.Parameters.AddWithValue("@n", txtUusKat.Text);
                cmd.ExecuteNonQuery();
                connect.Close();
                txtUusKat.Clear();
                LoadCategories();
                MessageBox.Show("Kategooria lisatud!");
            }
        }

        private void btnUuenda_Click(object sender, EventArgs e)
        {
            if (dataGridViewTooded.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewTooded.SelectedRows[0].Cells["Id"].Value);
                connect.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Tooded SET Toodenimetus=@n, Kogus=@k, Hind=@h, Kategooriad_ID=@kat WHERE Id=@id", connect);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@n", txtNimetus.Text);
                cmd.Parameters.AddWithValue("@k", txtKogus.Text);
                cmd.Parameters.AddWithValue("@h", txtHind.Text.Replace(',', '.'));
                cmd.Parameters.AddWithValue("@kat", cmbKategooria.SelectedValue);
                cmd.ExecuteNonQuery();
                connect.Close();
                RefreshEverything();
            }
        }

        private void btnKustuta_Click(object sender, EventArgs e)
        {
            if (dataGridViewTooded.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewTooded.SelectedRows[0].Cells["Id"].Value);
                connect.Open();
                new SqlCommand($"DELETE FROM Tooded WHERE Id={id}", connect).ExecuteNonQuery();
                connect.Close();
                RefreshEverything();
            }
        }
    }
}