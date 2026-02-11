namespace Pood_andmebaasiga
{
    partial class Tooded
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dataGridViewTooded = new System.Windows.Forms.DataGridView();
            this.btnLisa = new System.Windows.Forms.Button();
            this.btnUuenda = new System.Windows.Forms.Button();
            this.btnKustuta = new System.Windows.Forms.Button();
            this.btnLisaKat = new System.Windows.Forms.Button();
            this.txtNimetus = new System.Windows.Forms.TextBox();
            this.txtKogus = new System.Windows.Forms.TextBox();
            this.txtHind = new System.Windows.Forms.TextBox();
            this.txtUusKat = new System.Windows.Forms.TextBox();
            this.cmbKategooria = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTooded)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewTooded.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTooded.Size = new System.Drawing.Size(600, 180);
            this.dataGridViewTooded.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.txtNimetus.Location = new System.Drawing.Point(12, 210); this.txtNimetus.Size = new System.Drawing.Size(150, 20);
            this.txtKogus.Location = new System.Drawing.Point(12, 240); this.txtKogus.Size = new System.Drawing.Size(150, 20);
            this.txtHind.Location = new System.Drawing.Point(12, 270); this.txtHind.Size = new System.Drawing.Size(150, 20);
            this.cmbKategooria.Location = new System.Drawing.Point(12, 300); this.cmbKategooria.Size = new System.Drawing.Size(150, 20);

            this.btnLisa.Location = new System.Drawing.Point(180, 210); this.btnLisa.Text = "Lisa Toode";
            this.btnLisa.Click += new System.EventHandler(this.btnLisa_Click);

            this.btnUuenda.Location = new System.Drawing.Point(180, 240); this.btnUuenda.Text = "Uuenda Valitud";
            this.btnUuenda.Click += new System.EventHandler(this.btnUuenda_Click);

            this.btnKustuta.Location = new System.Drawing.Point(180, 270); this.btnKustuta.Text = "Kustuta Valitud";
            this.btnKustuta.Click += new System.EventHandler(this.btnKustuta_Click);

            // СЕКЦИЯ КАТЕГОРИЙ
            this.lblInfo.Location = new System.Drawing.Point(350, 210); this.lblInfo.Text = "Uus kategooria nimi:";
            this.txtUusKat.Location = new System.Drawing.Point(350, 230); this.txtUusKat.Size = new System.Drawing.Size(150, 20);
            this.btnLisaKat.Location = new System.Drawing.Point(350, 260); this.btnLisaKat.Text = "Lisa Kategooria";
            this.btnLisaKat.Click += new System.EventHandler(this.btnLisaKat_Click);

            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dataGridViewTooded, this.btnLisa, this.btnUuenda, this.btnKustuta,
                this.txtNimetus, this.txtKogus, this.txtHind, this.cmbKategooria,
                this.txtUusKat, this.btnLisaKat, this.lblInfo
            });
            this.Name = "Tooded";
            this.Text = "Laohaldus - Parandatud";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTooded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewTooded;
        private System.Windows.Forms.Button btnLisa, btnUuenda, btnKustuta, btnLisaKat;
        private System.Windows.Forms.TextBox txtNimetus, txtKogus, txtHind, txtUusKat;
        private System.Windows.Forms.ComboBox cmbKategooria;
        private System.Windows.Forms.Label lblInfo;
    }
}