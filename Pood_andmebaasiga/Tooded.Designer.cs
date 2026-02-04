namespace Pood_andmebaasiga
{
    partial class Tooded
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNimetus = new System.Windows.Forms.TextBox();
            this.txtKogus = new System.Windows.Forms.TextBox();
            this.txtHind = new System.Windows.Forms.TextBox();
            this.cmbKategooria = new System.Windows.Forms.ComboBox();
            this.picPilt = new System.Windows.Forms.PictureBox();
            this.dataGridTooted = new System.Windows.Forms.DataGridView();
            this.btnLisa = new System.Windows.Forms.Button();
            this.btnUuenda = new System.Windows.Forms.Button();
            this.btnKustuta = new System.Windows.Forms.Button();
            this.btnOtsiFail = new System.Windows.Forms.Button();
            this.btnLisaKategooria = new System.Windows.Forms.Button();
            this.btnKustutaKategooria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTooted)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNimetus
            // 
            this.txtNimetus.Location = new System.Drawing.Point(182, 188);
            this.txtNimetus.Name = "txtNimetus";
            this.txtNimetus.Size = new System.Drawing.Size(85, 20);
            // 
            // txtKogus
            // 
            this.txtKogus.Location = new System.Drawing.Point(273, 188);
            this.txtKogus.Name = "txtKogus";
            this.txtKogus.Size = new System.Drawing.Size(85, 20);
            // 
            // txtHind
            // 
            this.txtHind.Location = new System.Drawing.Point(364, 188);
            this.txtHind.Name = "txtHind";
            this.txtHind.Size = new System.Drawing.Size(85, 20);
            // 
            // cmbKategooria
            // 
            this.cmbKategooria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategooria.Location = new System.Drawing.Point(129, 80);
            this.cmbKategooria.Name = "cmbKategooria";
            this.cmbKategooria.Size = new System.Drawing.Size(121, 21);
            // 
            // picPilt
            // 
            this.picPilt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPilt.Location = new System.Drawing.Point(671, 270);
            this.picPilt.Name = "picPilt";
            this.picPilt.Size = new System.Drawing.Size(150, 150);
            this.picPilt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // dataGridTooted
            // 
            this.dataGridTooted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTooted.Location = new System.Drawing.Point(36, 229);
            this.dataGridTooted.Name = "dataGridTooted";
            this.dataGridTooted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTooted.Size = new System.Drawing.Size(600, 300);
            this.dataGridTooted.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTooted_CellClick);
            // 
            // btnLisa
            // 
            this.btnLisa.Location = new System.Drawing.Point(605, 188);
            this.btnLisa.Name = "btnLisa";
            this.btnLisa.Size = new System.Drawing.Size(75, 23);
            this.btnLisa.Text = "Lisa";
            this.btnLisa.Click += new System.EventHandler(this.btnLisa_Click);
            // 
            // btnUuenda
            // 
            this.btnUuenda.Location = new System.Drawing.Point(686, 188);
            this.btnUuenda.Name = "btnUuenda";
            this.btnUuenda.Size = new System.Drawing.Size(75, 23);
            this.btnUuenda.Text = "Uuenda";
            this.btnUuenda.Click += new System.EventHandler(this.btnUuenda_Click);
            // 
            // btnKustuta
            // 
            this.btnKustuta.Location = new System.Drawing.Point(767, 188);
            this.btnKustuta.Name = "btnKustuta";
            this.btnKustuta.Size = new System.Drawing.Size(75, 23);
            this.btnKustuta.Text = "Kustuta";
            this.btnKustuta.Click += new System.EventHandler(this.btnKustuta_Click);
            // 
            // btnOtsiFail
            // 
            this.btnOtsiFail.Location = new System.Drawing.Point(845, 270);
            this.btnOtsiFail.Name = "btnOtsiFail";
            this.btnOtsiFail.Size = new System.Drawing.Size(75, 23);
            this.btnOtsiFail.Text = "Otsi pilt";
            this.btnOtsiFail.Click += new System.EventHandler(this.btnOtsiPilt_Click);
            // 
            // btnLisaKategooria
            // 
            this.btnLisaKategooria.Location = new System.Drawing.Point(24, 78);
            this.btnLisaKategooria.Name = "btnLisaKategooria";
            this.btnLisaKategooria.Size = new System.Drawing.Size(75, 23);
            this.btnLisaKategooria.Text = "Lisa kat.";
            this.btnLisaKategooria.Click += new System.EventHandler(this.btnLisaKategooria_Click);
            // 
            // btnKustutaKategooria
            // 
            this.btnKustutaKategooria.Location = new System.Drawing.Point(24, 118);
            this.btnKustutaKategooria.Name = "btnKustutaKategooria";
            this.btnKustutaKategooria.Size = new System.Drawing.Size(75, 23);
            this.btnKustutaKategooria.Text = "Kustuta kat.";
            this.btnKustutaKategooria.Click += new System.EventHandler(this.btnKustutaKategooria_Click);
            // 
            // Tooded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnKustutaKategooria);
            this.Controls.Add(this.btnLisaKategooria);
            this.Controls.Add(this.btnOtsiFail);
            this.Controls.Add(this.btnKustuta);
            this.Controls.Add(this.btnUuenda);
            this.Controls.Add(this.btnLisa);
            this.Controls.Add(this.dataGridTooted);
            this.Controls.Add(this.picPilt);
            this.Controls.Add(this.cmbKategooria);
            this.Controls.Add(this.txtHind);
            this.Controls.Add(this.txtKogus);
            this.Controls.Add(this.txtNimetus);
            this.Name = "Tooded";
            this.Text = "Tooded";
            this.Load += new System.EventHandler(this.Tooded_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTooted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNimetus;
        private System.Windows.Forms.TextBox txtKogus;
        private System.Windows.Forms.TextBox txtHind;
        private System.Windows.Forms.ComboBox cmbKategooria;
        private System.Windows.Forms.PictureBox picPilt;
        private System.Windows.Forms.DataGridView dataGridTooted;
        private System.Windows.Forms.Button btnLisa;
        private System.Windows.Forms.Button btnUuenda;
        private System.Windows.Forms.Button btnKustuta;
        private System.Windows.Forms.Button btnOtsiFail;
        private System.Windows.Forms.Button btnLisaKategooria;
        private System.Windows.Forms.Button btnKustutaKategooria;
    }
}