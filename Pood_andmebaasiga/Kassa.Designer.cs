namespace Pood_andmebaasiga
{
    partial class Kassa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblTooted = new System.Windows.Forms.Label();
            this.txtOtsing = new System.Windows.Forms.TextBox();
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblKorv = new System.Windows.Forms.Label();
            this.txtKorvOtsing = new System.Windows.Forms.TextBox();
            this.dataGridViewKorv = new System.Windows.Forms.DataGridView();
            this.btnEemaldaKorvist = new System.Windows.Forms.Button();
            this.btnOsta = new System.Windows.Forms.Button();
            this.btnLisaKorvi = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.flowProducts);
            this.panelLeft.Controls.Add(this.txtOtsing);
            this.panelLeft.Controls.Add(this.lblTooted);
            this.panelLeft.Location = new System.Drawing.Point(8, 8);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(560, 620);
            // 
            // lblTooted
            // 
            this.lblTooted.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTooted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTooted.ForeColor = System.Drawing.Color.White;
            this.lblTooted.Location = new System.Drawing.Point(0, 0);
            this.lblTooted.Name = "lblTooted";
            this.lblTooted.Size = new System.Drawing.Size(558, 36);
            this.lblTooted.Text = "🛍️ Tooted";
            this.lblTooted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOtsing
            // 
            this.txtOtsing.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOtsing.Location = new System.Drawing.Point(5, 42);
            this.txtOtsing.Name = "txtOtsing";
            this.txtOtsing.Text = "";
            this.txtOtsing.Size = new System.Drawing.Size(548, 26);
            this.txtOtsing.TabIndex = 0;
            this.txtOtsing.TextChanged += new System.EventHandler(this.txtOtsing_TextChanged);
            // 
            // flowProducts
            // 
            this.flowProducts.AutoScroll = true;
            this.flowProducts.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.flowProducts.Location = new System.Drawing.Point(5, 74);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Size = new System.Drawing.Size(548, 540);
            this.flowProducts.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(255, 249, 196);
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.btnOsta);
            this.panelRight.Controls.Add(this.btnEemaldaKorvist);
            this.panelRight.Controls.Add(this.dataGridViewKorv);
            this.panelRight.Controls.Add(this.txtKorvOtsing);
            this.panelRight.Controls.Add(this.lblKorv);
            this.panelRight.Location = new System.Drawing.Point(580, 8);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(390, 620);
            // 
            // lblKorv
            // 
            this.lblKorv.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblKorv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKorv.ForeColor = System.Drawing.Color.White;
            this.lblKorv.Location = new System.Drawing.Point(0, 0);
            this.lblKorv.Name = "lblKorv";
            this.lblKorv.Size = new System.Drawing.Size(388, 36);
            this.lblKorv.Text = "🛒 Ostukorv";
            this.lblKorv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKorvOtsing
            // 
            this.txtKorvOtsing.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKorvOtsing.Location = new System.Drawing.Point(5, 42);
            this.txtKorvOtsing.Name = "txtKorvOtsing";
            this.txtKorvOtsing.Text = "";
            this.txtKorvOtsing.Size = new System.Drawing.Size(378, 26);
            this.txtKorvOtsing.TabIndex = 2;
            this.txtKorvOtsing.TextChanged += new System.EventHandler(this.txtKorvOtsing_TextChanged);
            // 
            // dataGridViewKorv
            // 
            this.dataGridViewKorv.AllowUserToAddRows = false;
            this.dataGridViewKorv.BackgroundColor = System.Drawing.Color.FromArgb(255, 249, 196);
            this.dataGridViewKorv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorv.Location = new System.Drawing.Point(5, 74);
            this.dataGridViewKorv.Name = "dataGridViewKorv";
            this.dataGridViewKorv.ReadOnly = true;
            this.dataGridViewKorv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKorv.Size = new System.Drawing.Size(378, 460);
            this.dataGridViewKorv.TabIndex = 3;
            // 
            // btnEemaldaKorvist
            // 
            this.btnEemaldaKorvist.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnEemaldaKorvist.FlatAppearance.BorderSize = 0;
            this.btnEemaldaKorvist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEemaldaKorvist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEemaldaKorvist.ForeColor = System.Drawing.Color.White;
            this.btnEemaldaKorvist.Location = new System.Drawing.Point(5, 540);
            this.btnEemaldaKorvist.Name = "btnEemaldaKorvist";
            this.btnEemaldaKorvist.Size = new System.Drawing.Size(180, 32);
            this.btnEemaldaKorvist.TabIndex = 4;
            this.btnEemaldaKorvist.Text = "Eemalda korvist";
            this.btnEemaldaKorvist.UseVisualStyleBackColor = false;
            this.btnEemaldaKorvist.Click += new System.EventHandler(this.btnEemaldaKorvist_Click);
            // 
            // btnOsta
            // 
            this.btnOsta.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnOsta.FlatAppearance.BorderSize = 0;
            this.btnOsta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOsta.ForeColor = System.Drawing.Color.White;
            this.btnOsta.Location = new System.Drawing.Point(5, 578);
            this.btnOsta.Name = "btnOsta";
            this.btnOsta.Size = new System.Drawing.Size(378, 36);
            this.btnOsta.TabIndex = 5;
            this.btnOsta.Text = "✅ Osta / PDF";
            this.btnOsta.UseVisualStyleBackColor = false;
            this.btnOsta.Click += new System.EventHandler(this.btnOsta_Click);
            // 
            // btnLisaKorvi (kept for Designer compatibility, hidden)
            // 
            this.btnLisaKorvi.Location = new System.Drawing.Point(0, 0);
            this.btnLisaKorvi.Name = "btnLisaKorvi";
            this.btnLisaKorvi.Size = new System.Drawing.Size(1, 1);
            this.btnLisaKorvi.TabIndex = 99;
            this.btnLisaKorvi.Text = "Lisa >>";
            this.btnLisaKorvi.Visible = false;
            this.btnLisaKorvi.Click += new System.EventHandler(this.btnLisaKorvi_Click);
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.ClientSize = new System.Drawing.Size(980, 638);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.btnLisaKorvi);
            this.Name = "Kassa";
            this.Text = "🛒 Kassa ja Ostukorv";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorv)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblTooted;
        private System.Windows.Forms.Label lblKorv;
        private System.Windows.Forms.TextBox txtOtsing;
        private System.Windows.Forms.TextBox txtKorvOtsing;
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
        private System.Windows.Forms.DataGridView dataGridViewKorv;
        private System.Windows.Forms.Button btnLisaKorvi;
        private System.Windows.Forms.Button btnEemaldaKorvist;
        private System.Windows.Forms.Button btnOsta;
    }
}
