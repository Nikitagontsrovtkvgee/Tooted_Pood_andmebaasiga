namespace Pood_andmebaasiga
{
    partial class Login
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.lblKasutaja = new System.Windows.Forms.Label();
            this.txtKasutaja = new System.Windows.Forms.TextBox();
            this.lblParool = new System.Windows.Forms.Label();
            this.txtParool = new System.Windows.Forms.TextBox();
            this.btnLogiSisse = new System.Windows.Forms.Button();
            this.btnRegistreeri = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.Name = "panelHeader";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "🛒 Pood - Sisselogimine";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelCenter.Controls.Add(this.lblKasutaja);
            this.panelCenter.Controls.Add(this.txtKasutaja);
            this.panelCenter.Controls.Add(this.lblParool);
            this.panelCenter.Controls.Add(this.txtParool);
            this.panelCenter.Controls.Add(this.btnLogiSisse);
            this.panelCenter.Controls.Add(this.btnRegistreeri);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Name = "panelCenter";
            // 
            // lblKasutaja
            // 
            this.lblKasutaja.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKasutaja.ForeColor = System.Drawing.Color.White;
            this.lblKasutaja.Location = new System.Drawing.Point(100, 60);
            this.lblKasutaja.Name = "lblKasutaja";
            this.lblKasutaja.Size = new System.Drawing.Size(200, 22);
            this.lblKasutaja.Text = "Kasutajanimi:";
            // 
            // txtKasutaja
            // 
            this.txtKasutaja.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.txtKasutaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKasutaja.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKasutaja.ForeColor = System.Drawing.Color.White;
            this.txtKasutaja.Location = new System.Drawing.Point(100, 85);
            this.txtKasutaja.Name = "txtKasutaja";
            this.txtKasutaja.Size = new System.Drawing.Size(200, 26);
            this.txtKasutaja.TabIndex = 0;
            // 
            // lblParool
            // 
            this.lblParool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblParool.ForeColor = System.Drawing.Color.White;
            this.lblParool.Location = new System.Drawing.Point(100, 125);
            this.lblParool.Name = "lblParool";
            this.lblParool.Size = new System.Drawing.Size(200, 22);
            this.lblParool.Text = "Parool:";
            // 
            // txtParool
            // 
            this.txtParool.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.txtParool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtParool.ForeColor = System.Drawing.Color.White;
            this.txtParool.Location = new System.Drawing.Point(100, 150);
            this.txtParool.Name = "txtParool";
            this.txtParool.PasswordChar = '*';
            this.txtParool.Size = new System.Drawing.Size(200, 26);
            this.txtParool.TabIndex = 1;
            // 
            // btnLogiSisse
            // 
            this.btnLogiSisse.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnLogiSisse.FlatAppearance.BorderSize = 0;
            this.btnLogiSisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogiSisse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogiSisse.ForeColor = System.Drawing.Color.White;
            this.btnLogiSisse.Location = new System.Drawing.Point(100, 200);
            this.btnLogiSisse.Name = "btnLogiSisse";
            this.btnLogiSisse.Size = new System.Drawing.Size(95, 32);
            this.btnLogiSisse.TabIndex = 2;
            this.btnLogiSisse.Text = "Logi sisse";
            this.btnLogiSisse.UseVisualStyleBackColor = false;
            this.btnLogiSisse.Click += new System.EventHandler(this.btnLogiSisse_Click);
            // 
            // btnRegistreeri
            // 
            this.btnRegistreeri.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnRegistreeri.FlatAppearance.BorderSize = 0;
            this.btnRegistreeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistreeri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistreeri.ForeColor = System.Drawing.Color.White;
            this.btnRegistreeri.Location = new System.Drawing.Point(205, 200);
            this.btnRegistreeri.Name = "btnRegistreeri";
            this.btnRegistreeri.Size = new System.Drawing.Size(95, 32);
            this.btnRegistreeri.TabIndex = 3;
            this.btnRegistreeri.Text = "Registreeri";
            this.btnRegistreeri.UseVisualStyleBackColor = false;
            this.btnRegistreeri.Click += new System.EventHandler(this.btnRegistreeri_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🛒 Pood - Sisselogimine";
            this.panelHeader.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label lblKasutaja;
        private System.Windows.Forms.TextBox txtKasutaja;
        private System.Windows.Forms.Label lblParool;
        private System.Windows.Forms.TextBox txtParool;
        private System.Windows.Forms.Button btnLogiSisse;
        private System.Windows.Forms.Button btnRegistreeri;
    }
}
