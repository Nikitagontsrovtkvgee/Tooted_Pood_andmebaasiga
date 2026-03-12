namespace Pood_andmebaasiga
{
    partial class Register
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.lblNimi = new System.Windows.Forms.Label();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.lblParool = new System.Windows.Forms.Label();
            this.txtParool = new System.Windows.Forms.TextBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.cmbRoll = new System.Windows.Forms.ComboBox();
            this.btnRegistreeri = new System.Windows.Forms.Button();
            this.btnTühista = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 55;
            this.panelHeader.Name = "panelHeader";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "👤 Registreeri kasutaja";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelBody.Controls.Add(this.lblNimi);
            this.panelBody.Controls.Add(this.txtNimi);
            this.panelBody.Controls.Add(this.lblParool);
            this.panelBody.Controls.Add(this.txtParool);
            this.panelBody.Controls.Add(this.lblRoll);
            this.panelBody.Controls.Add(this.cmbRoll);
            this.panelBody.Controls.Add(this.btnRegistreeri);
            this.panelBody.Controls.Add(this.btnTühista);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Name = "panelBody";
            // 
            // lblNimi
            // 
            this.lblNimi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNimi.ForeColor = System.Drawing.Color.White;
            this.lblNimi.Location = new System.Drawing.Point(80, 30);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(200, 22);
            this.lblNimi.Text = "Kasutajanimi:";
            // 
            // txtNimi
            // 
            this.txtNimi.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.txtNimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNimi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNimi.ForeColor = System.Drawing.Color.White;
            this.txtNimi.Location = new System.Drawing.Point(80, 55);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(200, 26);
            this.txtNimi.TabIndex = 0;
            // 
            // lblParool
            // 
            this.lblParool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblParool.ForeColor = System.Drawing.Color.White;
            this.lblParool.Location = new System.Drawing.Point(80, 90);
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
            this.txtParool.Location = new System.Drawing.Point(80, 115);
            this.txtParool.Name = "txtParool";
            this.txtParool.PasswordChar = '*';
            this.txtParool.Size = new System.Drawing.Size(200, 26);
            this.txtParool.TabIndex = 1;
            // 
            // lblRoll
            // 
            this.lblRoll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoll.ForeColor = System.Drawing.Color.White;
            this.lblRoll.Location = new System.Drawing.Point(80, 150);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(200, 22);
            this.lblRoll.Text = "Roll:";
            // 
            // cmbRoll
            // 
            this.cmbRoll.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.cmbRoll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoll.ForeColor = System.Drawing.Color.White;
            this.cmbRoll.Items.AddRange(new object[] { "Müüja", "Omanik" });
            this.cmbRoll.Location = new System.Drawing.Point(80, 175);
            this.cmbRoll.Name = "cmbRoll";
            this.cmbRoll.SelectedIndex = 0;
            this.cmbRoll.Size = new System.Drawing.Size(200, 26);
            this.cmbRoll.TabIndex = 2;
            // 
            // btnRegistreeri
            // 
            this.btnRegistreeri.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnRegistreeri.FlatAppearance.BorderSize = 0;
            this.btnRegistreeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistreeri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistreeri.ForeColor = System.Drawing.Color.White;
            this.btnRegistreeri.Location = new System.Drawing.Point(80, 220);
            this.btnRegistreeri.Name = "btnRegistreeri";
            this.btnRegistreeri.Size = new System.Drawing.Size(95, 32);
            this.btnRegistreeri.TabIndex = 3;
            this.btnRegistreeri.Text = "Registreeri";
            this.btnRegistreeri.UseVisualStyleBackColor = false;
            this.btnRegistreeri.Click += new System.EventHandler(this.btnRegistreeri_Click);
            // 
            // btnTühista
            // 
            this.btnTühista.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnTühista.FlatAppearance.BorderSize = 0;
            this.btnTühista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTühista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTühista.ForeColor = System.Drawing.Color.White;
            this.btnTühista.Location = new System.Drawing.Point(185, 220);
            this.btnTühista.Name = "btnTühista";
            this.btnTühista.Size = new System.Drawing.Size(95, 32);
            this.btnTühista.TabIndex = 4;
            this.btnTühista.Text = "Tühista";
            this.btnTühista.UseVisualStyleBackColor = false;
            this.btnTühista.Click += new System.EventHandler(this.btnTühista_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.ClientSize = new System.Drawing.Size(360, 330);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registreeri kasutaja";
            this.panelHeader.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.Label lblParool;
        private System.Windows.Forms.TextBox txtParool;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.ComboBox cmbRoll;
        private System.Windows.Forms.Button btnRegistreeri;
        private System.Windows.Forms.Button btnTühista;
    }
}
