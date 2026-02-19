namespace Pood_andmebaasiga
{
    partial class Kassa
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dataGridViewKassa = new System.Windows.Forms.DataGridView();
            this.btnOsta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKassa)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewKassa.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewKassa.Name = "dataGridViewKassa";
            this.dataGridViewKassa.Size = new System.Drawing.Size(400, 200);

            this.btnOsta.Location = new System.Drawing.Point(12, 230);
            this.btnOsta.Text = "Osta / PDF";
            this.btnOsta.Click += new System.EventHandler(this.btnOsta_Click);

            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.btnOsta);
            this.Controls.Add(this.dataGridViewKassa);
            this.Name = "Kassa";
            this.Text = "Kassa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKassa)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewKassa;
        private System.Windows.Forms.Button btnOsta;
    }
}
