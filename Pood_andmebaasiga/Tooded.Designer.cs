namespace Pood_andmebaasiga
{
    partial class Tooded
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dataGridViewTooded = new System.Windows.Forms.DataGridView();
            this.btnLisa = new System.Windows.Forms.Button();
            this.btnUuenda = new System.Windows.Forms.Button();
            this.btnKustuta = new System.Windows.Forms.Button();
            this.btnAvaKassa = new System.Windows.Forms.Button();
            this.btnAdminPaneel = new System.Windows.Forms.Button();
            this.btnLisaKat = new System.Windows.Forms.Button();
            this.txtNimetus = new System.Windows.Forms.TextBox();
            this.txtKogus = new System.Windows.Forms.TextBox();
            this.txtHind = new System.Windows.Forms.TextBox();
            this.txtUusKat = new System.Windows.Forms.TextBox();
            this.cmbKategooria = new System.Windows.Forms.ComboBox();
            this.picPilt = new System.Windows.Forms.PictureBox();
            this.btnOtsiPilt = new System.Windows.Forms.Button();
            this.lblNimetus = new System.Windows.Forms.Label();
            this.lblKogus = new System.Windows.Forms.Label();
            this.lblHind = new System.Windows.Forms.Label();
            this.lblKat = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTooded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPilt)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 50;
            this.panelHeader.Name = "panelHeader";
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Text = "📦 Toode Haldus";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTooded
            // 
            this.dataGridViewTooded.AllowUserToAddRows = false;
            this.dataGridViewTooded.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTooded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTooded.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewTooded.Name = "dataGridViewTooded";
            this.dataGridViewTooded.ReadOnly = true;
            this.dataGridViewTooded.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTooded.Size = new System.Drawing.Size(750, 220);
            this.dataGridViewTooded.TabIndex = 0;
            this.dataGridViewTooded.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTooded_CellClick);
            // 
            // lblNimetus
            // 
            this.lblNimetus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNimetus.Location = new System.Drawing.Point(12, 295);
            this.lblNimetus.Name = "lblNimetus";
            this.lblNimetus.Size = new System.Drawing.Size(130, 18);
            this.lblNimetus.Text = "Tootenimetus:";
            // 
            // txtNimetus
            // 
            this.txtNimetus.Location = new System.Drawing.Point(12, 315);
            this.txtNimetus.Name = "txtNimetus";
            this.txtNimetus.Size = new System.Drawing.Size(150, 20);
            this.txtNimetus.TabIndex = 6;
            // 
            // lblKogus
            // 
            this.lblKogus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKogus.Location = new System.Drawing.Point(12, 345);
            this.lblKogus.Name = "lblKogus";
            this.lblKogus.Size = new System.Drawing.Size(130, 18);
            this.lblKogus.Text = "Kogus:";
            // 
            // txtKogus
            // 
            this.txtKogus.Location = new System.Drawing.Point(12, 365);
            this.txtKogus.Name = "txtKogus";
            this.txtKogus.Size = new System.Drawing.Size(150, 20);
            this.txtKogus.TabIndex = 7;
            // 
            // lblHind
            // 
            this.lblHind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHind.Location = new System.Drawing.Point(12, 395);
            this.lblHind.Name = "lblHind";
            this.lblHind.Size = new System.Drawing.Size(130, 18);
            this.lblHind.Text = "Hind (€):";
            // 
            // txtHind
            // 
            this.txtHind.Location = new System.Drawing.Point(12, 415);
            this.txtHind.Name = "txtHind";
            this.txtHind.Size = new System.Drawing.Size(150, 20);
            this.txtHind.TabIndex = 8;
            // 
            // lblKat
            // 
            this.lblKat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKat.Location = new System.Drawing.Point(12, 445);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(130, 18);
            this.lblKat.Text = "Kategooria:";
            // 
            // cmbKategooria
            // 
            this.cmbKategooria.FormattingEnabled = true;
            this.cmbKategooria.Location = new System.Drawing.Point(12, 465);
            this.cmbKategooria.Name = "cmbKategooria";
            this.cmbKategooria.Size = new System.Drawing.Size(150, 21);
            this.cmbKategooria.TabIndex = 10;
            // 
            // txtUusKat
            // 
            this.txtUusKat.Location = new System.Drawing.Point(200, 445);
            this.txtUusKat.Name = "txtUusKat";
            this.txtUusKat.Size = new System.Drawing.Size(130, 20);
            this.txtUusKat.TabIndex = 9;
            // 
            // btnLisaKat
            // 
            this.btnLisaKat.Location = new System.Drawing.Point(200, 470);
            this.btnLisaKat.Name = "btnLisaKat";
            this.btnLisaKat.Size = new System.Drawing.Size(130, 26);
            this.btnLisaKat.TabIndex = 5;
            this.btnLisaKat.Text = "Lisa Kategooria";
            this.btnLisaKat.UseVisualStyleBackColor = true;
            this.btnLisaKat.Click += new System.EventHandler(this.btnLisaKat_Click);
            // 
            // btnLisa
            // 
            this.btnLisa.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnLisa.FlatAppearance.BorderSize = 0;
            this.btnLisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLisa.ForeColor = System.Drawing.Color.White;
            this.btnLisa.Location = new System.Drawing.Point(12, 510);
            this.btnLisa.Name = "btnLisa";
            this.btnLisa.Size = new System.Drawing.Size(100, 28);
            this.btnLisa.TabIndex = 1;
            this.btnLisa.Text = "Lisa Toode";
            this.btnLisa.UseVisualStyleBackColor = false;
            this.btnLisa.Click += new System.EventHandler(this.btnLisa_Click);
            // 
            // btnUuenda
            // 
            this.btnUuenda.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnUuenda.FlatAppearance.BorderSize = 0;
            this.btnUuenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUuenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUuenda.ForeColor = System.Drawing.Color.White;
            this.btnUuenda.Location = new System.Drawing.Point(122, 510);
            this.btnUuenda.Name = "btnUuenda";
            this.btnUuenda.Size = new System.Drawing.Size(100, 28);
            this.btnUuenda.TabIndex = 2;
            this.btnUuenda.Text = "Uuenda";
            this.btnUuenda.UseVisualStyleBackColor = false;
            this.btnUuenda.Click += new System.EventHandler(this.btnUuenda_Click);
            // 
            // btnKustuta
            // 
            this.btnKustuta.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnKustuta.FlatAppearance.BorderSize = 0;
            this.btnKustuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKustuta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKustuta.ForeColor = System.Drawing.Color.White;
            this.btnKustuta.Location = new System.Drawing.Point(232, 510);
            this.btnKustuta.Name = "btnKustuta";
            this.btnKustuta.Size = new System.Drawing.Size(100, 28);
            this.btnKustuta.TabIndex = 3;
            this.btnKustuta.Text = "Kustuta";
            this.btnKustuta.UseVisualStyleBackColor = false;
            this.btnKustuta.Click += new System.EventHandler(this.btnKustuta_Click);
            // 
            // picPilt
            // 
            this.picPilt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPilt.Location = new System.Drawing.Point(540, 295);
            this.picPilt.Name = "picPilt";
            this.picPilt.Size = new System.Drawing.Size(222, 180);
            this.picPilt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPilt.TabIndex = 11;
            this.picPilt.TabStop = false;
            // 
            // btnOtsiPilt
            // 
            this.btnOtsiPilt.Location = new System.Drawing.Point(540, 483);
            this.btnOtsiPilt.Name = "btnOtsiPilt";
            this.btnOtsiPilt.Size = new System.Drawing.Size(100, 26);
            this.btnOtsiPilt.TabIndex = 12;
            this.btnOtsiPilt.Text = "Vali foto";
            this.btnOtsiPilt.UseVisualStyleBackColor = true;
            this.btnOtsiPilt.Click += new System.EventHandler(this.btnOtsiPilt_Click);
            // 
            // btnAvaKassa
            // 
            this.btnAvaKassa.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAvaKassa.FlatAppearance.BorderSize = 0;
            this.btnAvaKassa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvaKassa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAvaKassa.ForeColor = System.Drawing.Color.White;
            this.btnAvaKassa.Location = new System.Drawing.Point(600, 515);
            this.btnAvaKassa.Name = "btnAvaKassa";
            this.btnAvaKassa.Size = new System.Drawing.Size(110, 28);
            this.btnAvaKassa.TabIndex = 4;
            this.btnAvaKassa.Text = "Ava Kassa";
            this.btnAvaKassa.UseVisualStyleBackColor = false;
            this.btnAvaKassa.Click += new System.EventHandler(this.btnAvaKassa_Click);
            // 
            // btnAdminPaneel
            // 
            this.btnAdminPaneel.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnAdminPaneel.FlatAppearance.BorderSize = 0;
            this.btnAdminPaneel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPaneel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdminPaneel.ForeColor = System.Drawing.Color.White;
            this.btnAdminPaneel.Location = new System.Drawing.Point(480, 515);
            this.btnAdminPaneel.Name = "btnAdminPaneel";
            this.btnAdminPaneel.Size = new System.Drawing.Size(110, 28);
            this.btnAdminPaneel.TabIndex = 13;
            this.btnAdminPaneel.Text = "Admin Paneel";
            this.btnAdminPaneel.UseVisualStyleBackColor = false;
            this.btnAdminPaneel.Click += new System.EventHandler(this.btnAdminPaneel_Click);
            // 
            // Tooded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(776, 555);
            this.Controls.Add(this.btnAdminPaneel);
            this.Controls.Add(this.btnOtsiPilt);
            this.Controls.Add(this.picPilt);
            this.Controls.Add(this.dataGridViewTooded);
            this.Controls.Add(this.btnLisa);
            this.Controls.Add(this.btnUuenda);
            this.Controls.Add(this.btnKustuta);
            this.Controls.Add(this.btnAvaKassa);
            this.Controls.Add(this.btnLisaKat);
            this.Controls.Add(this.txtNimetus);
            this.Controls.Add(this.txtKogus);
            this.Controls.Add(this.txtHind);
            this.Controls.Add(this.txtUusKat);
            this.Controls.Add(this.cmbKategooria);
            this.Controls.Add(this.lblNimetus);
            this.Controls.Add(this.lblKogus);
            this.Controls.Add(this.lblHind);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.panelHeader);
            this.Name = "Tooded";
            this.Text = "📦 Toode Haldus";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTooded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPilt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dataGridViewTooded;
        private System.Windows.Forms.Button btnLisa, btnUuenda, btnKustuta, btnAvaKassa, btnLisaKat, btnAdminPaneel;
        private System.Windows.Forms.TextBox txtNimetus, txtKogus, txtHind, txtUusKat;
        private System.Windows.Forms.ComboBox cmbKategooria;
        private System.Windows.Forms.PictureBox picPilt;
        private System.Windows.Forms.Button btnOtsiPilt;
        private System.Windows.Forms.Label lblNimetus, lblKogus, lblHind, lblKat;
    }
}
