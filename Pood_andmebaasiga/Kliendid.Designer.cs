namespace Pood_andmebaasiga
{
    partial class Kliendid
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewKliendid = new System.Windows.Forms.DataGridView();
            this.lblNimi = new System.Windows.Forms.Label();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.lblKliendikaart = new System.Windows.Forms.Label();
            this.txtKliendikaart = new System.Windows.Forms.TextBox();
            this.btnLisaKlient = new System.Windows.Forms.Button();
            this.btnKustutaKlient = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKliendid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 50;
            this.panelHeader.Name = "panelHeader";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "👥 Kliendid";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKliendid
            // 
            this.dataGridViewKliendid.AllowUserToAddRows = false;
            this.dataGridViewKliendid.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKliendid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKliendid.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewKliendid.Name = "dataGridViewKliendid";
            this.dataGridViewKliendid.ReadOnly = true;
            this.dataGridViewKliendid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKliendid.Size = new System.Drawing.Size(560, 300);
            this.dataGridViewKliendid.TabIndex = 0;
            // 
            // lblNimi
            // 
            this.lblNimi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNimi.Location = new System.Drawing.Point(12, 375);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(120, 20);
            this.lblNimi.Text = "Nimi:";
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(12, 395);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(160, 20);
            this.txtNimi.TabIndex = 1;
            // 
            // lblKliendikaart
            // 
            this.lblKliendikaart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKliendikaart.Location = new System.Drawing.Point(190, 375);
            this.lblKliendikaart.Name = "lblKliendikaart";
            this.lblKliendikaart.Size = new System.Drawing.Size(140, 20);
            this.lblKliendikaart.Text = "Kliendikaart:";
            // 
            // txtKliendikaart
            // 
            this.txtKliendikaart.Location = new System.Drawing.Point(190, 395);
            this.txtKliendikaart.Name = "txtKliendikaart";
            this.txtKliendikaart.Size = new System.Drawing.Size(160, 20);
            this.txtKliendikaart.TabIndex = 2;
            // 
            // btnLisaKlient
            // 
            this.btnLisaKlient.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnLisaKlient.FlatAppearance.BorderSize = 0;
            this.btnLisaKlient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisaKlient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLisaKlient.ForeColor = System.Drawing.Color.White;
            this.btnLisaKlient.Location = new System.Drawing.Point(12, 430);
            this.btnLisaKlient.Name = "btnLisaKlient";
            this.btnLisaKlient.Size = new System.Drawing.Size(130, 30);
            this.btnLisaKlient.TabIndex = 3;
            this.btnLisaKlient.Text = "Lisa klient";
            this.btnLisaKlient.UseVisualStyleBackColor = false;
            this.btnLisaKlient.Click += new System.EventHandler(this.btnLisaKlient_Click);
            // 
            // btnKustutaKlient
            // 
            this.btnKustutaKlient.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnKustutaKlient.FlatAppearance.BorderSize = 0;
            this.btnKustutaKlient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKustutaKlient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKustutaKlient.ForeColor = System.Drawing.Color.White;
            this.btnKustutaKlient.Location = new System.Drawing.Point(155, 430);
            this.btnKustutaKlient.Name = "btnKustutaKlient";
            this.btnKustutaKlient.Size = new System.Drawing.Size(130, 30);
            this.btnKustutaKlient.TabIndex = 4;
            this.btnKustutaKlient.Text = "Kustuta klient";
            this.btnKustutaKlient.UseVisualStyleBackColor = false;
            this.btnKustutaKlient.Click += new System.EventHandler(this.btnKustutaKlient_Click);
            // 
            // Kliendid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(584, 480);
            this.Controls.Add(this.btnKustutaKlient);
            this.Controls.Add(this.btnLisaKlient);
            this.Controls.Add(this.txtKliendikaart);
            this.Controls.Add(this.lblKliendikaart);
            this.Controls.Add(this.txtNimi);
            this.Controls.Add(this.lblNimi);
            this.Controls.Add(this.dataGridViewKliendid);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Kliendid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kliendid";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKliendid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridViewKliendid;
        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.Label lblKliendikaart;
        private System.Windows.Forms.TextBox txtKliendikaart;
        private System.Windows.Forms.Button btnLisaKlient;
        private System.Windows.Forms.Button btnKustutaKlient;
    }
}
