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
            this.dataGridViewShop = new System.Windows.Forms.DataGridView();
            this.dataGridViewKorv = new System.Windows.Forms.DataGridView();
            this.btnLisaKorvi = new System.Windows.Forms.Button();
            this.btnOsta = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShop
            // 
            this.dataGridViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShop.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShop.Name = "dataGridViewShop";
            this.dataGridViewShop.Size = new System.Drawing.Size(280, 250);
            this.dataGridViewShop.TabIndex = 0;
            // 
            // dataGridViewKorv
            // 
            this.dataGridViewKorv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorv.Location = new System.Drawing.Point(400, 12);
            this.dataGridViewKorv.Name = "dataGridViewKorv";
            this.dataGridViewKorv.Size = new System.Drawing.Size(280, 250);
            this.dataGridViewKorv.TabIndex = 1;
            // 
            // btnLisaKorvi
            // 
            this.btnLisaKorvi.Location = new System.Drawing.Point(305, 100);
            this.btnLisaKorvi.Name = "btnLisaKorvi";
            this.btnLisaKorvi.Size = new System.Drawing.Size(80, 45);
            this.btnLisaKorvi.TabIndex = 2;
            this.btnLisaKorvi.Text = "Lisa >>";
            this.btnLisaKorvi.Click += new System.EventHandler(this.btnLisaKorvi_Click);
            // 
            // btnOsta
            // 
            this.btnOsta.Location = new System.Drawing.Point(400, 280);
            this.btnOsta.Name = "btnOsta";
            this.btnOsta.Size = new System.Drawing.Size(280, 40);
            this.btnOsta.TabIndex = 3;
            this.btnOsta.Text = "Osta / PDF";
            this.btnOsta.Click += new System.EventHandler(this.btnOsta_Click);
            // 
            // Kassa
            // 
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.btnOsta);
            this.Controls.Add(this.btnLisaKorvi);
            this.Controls.Add(this.dataGridViewKorv);
            this.Controls.Add(this.dataGridViewShop);
            this.Name = "Kassa";
            this.Text = "Kassa ja Ostukorv";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorv)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewShop;
        private System.Windows.Forms.DataGridView dataGridViewKorv;
        private System.Windows.Forms.Button btnLisaKorvi;
        private System.Windows.Forms.Button btnOsta;
        private System.Windows.Forms.Label lblStatus;
    }
}