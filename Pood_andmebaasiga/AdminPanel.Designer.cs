namespace Pood_andmebaasiga
{
    partial class AdminPanel
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnKustutaKasutaja = new System.Windows.Forms.Button();
            this.btnAvaKliendid = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
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
            this.lblTitle.Text = "🔧 Admin Paneel - Kasutajad";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(560, 360);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // btnKustutaKasutaja
            // 
            this.btnKustutaKasutaja.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnKustutaKasutaja.FlatAppearance.BorderSize = 0;
            this.btnKustutaKasutaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKustutaKasutaja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKustutaKasutaja.ForeColor = System.Drawing.Color.White;
            this.btnKustutaKasutaja.Location = new System.Drawing.Point(12, 438);
            this.btnKustutaKasutaja.Name = "btnKustutaKasutaja";
            this.btnKustutaKasutaja.Size = new System.Drawing.Size(180, 32);
            this.btnKustutaKasutaja.TabIndex = 1;
            this.btnKustutaKasutaja.Text = "Kustuta kasutaja";
            this.btnKustutaKasutaja.UseVisualStyleBackColor = false;
            this.btnKustutaKasutaja.Click += new System.EventHandler(this.btnKustutaKasutaja_Click);
            // 
            // btnAvaKliendid
            // 
            this.btnAvaKliendid.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAvaKliendid.FlatAppearance.BorderSize = 0;
            this.btnAvaKliendid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvaKliendid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAvaKliendid.ForeColor = System.Drawing.Color.White;
            this.btnAvaKliendid.Location = new System.Drawing.Point(392, 438);
            this.btnAvaKliendid.Name = "btnAvaKliendid";
            this.btnAvaKliendid.Size = new System.Drawing.Size(180, 32);
            this.btnAvaKliendid.TabIndex = 2;
            this.btnAvaKliendid.Text = "Kliendid";
            this.btnAvaKliendid.UseVisualStyleBackColor = false;
            this.btnAvaKliendid.Click += new System.EventHandler(this.btnAvaKliendid_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(584, 490);
            this.Controls.Add(this.btnAvaKliendid);
            this.Controls.Add(this.btnKustutaKasutaja);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Paneel";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnKustutaKasutaja;
        private System.Windows.Forms.Button btnAvaKliendid;
    }
}
