namespace Pood_andmebaasiga
{
    partial class Kassa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridKassa = new System.Windows.Forms.DataGridView();
            this.numKogus = new System.Windows.Forms.NumericUpDown();
            this.listOstukorv = new System.Windows.Forms.ListBox();
            this.lblSumma = new System.Windows.Forms.Label();
            this.btnLisaOstukorvi = new System.Windows.Forms.Button();
            this.btnMuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKassa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKogus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKassa
            // 
            this.dataGridKassa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKassa.Location = new System.Drawing.Point(248, 158);
            this.dataGridKassa.Name = "dataGridKassa";
            this.dataGridKassa.Size = new System.Drawing.Size(240, 150);
            this.dataGridKassa.TabIndex = 0;
            // 
            // numKogus
            // 
            this.numKogus.Location = new System.Drawing.Point(74, 88);
            this.numKogus.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKogus.Name = "numKogus";
            this.numKogus.Size = new System.Drawing.Size(120, 20);
            this.numKogus.TabIndex = 1;
            this.numKogus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listOstukorv
            // 
            this.listOstukorv.FormattingEnabled = true;
            this.listOstukorv.Location = new System.Drawing.Point(52, 148);
            this.listOstukorv.Name = "listOstukorv";
            this.listOstukorv.Size = new System.Drawing.Size(120, 95);
            this.listOstukorv.TabIndex = 2;
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(120, 29);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(35, 13);
            this.lblSumma.TabIndex = 3;
            this.lblSumma.Text = "label1";
            // 
            // btnLisaOstukorvi
            // 
            this.btnLisaOstukorvi.Location = new System.Drawing.Point(248, 47);
            this.btnLisaOstukorvi.Name = "btnLisaOstukorvi";
            this.btnLisaOstukorvi.Size = new System.Drawing.Size(75, 23);
            this.btnLisaOstukorvi.TabIndex = 4;
            this.btnLisaOstukorvi.Text = "button1";
            this.btnLisaOstukorvi.UseVisualStyleBackColor = true;
            // 
            // btnMuu
            // 
            this.btnMuu.Location = new System.Drawing.Point(394, 46);
            this.btnMuu.Name = "btnMuu";
            this.btnMuu.Size = new System.Drawing.Size(75, 23);
            this.btnMuu.TabIndex = 5;
            this.btnMuu.Text = "button2";
            this.btnMuu.UseVisualStyleBackColor = true;
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMuu);
            this.Controls.Add(this.btnLisaOstukorvi);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.listOstukorv);
            this.Controls.Add(this.numKogus);
            this.Controls.Add(this.dataGridKassa);
            this.Name = "Kassa";
            this.Text = "Kassa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKassa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKogus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridKassa;
        private System.Windows.Forms.NumericUpDown numKogus;
        private System.Windows.Forms.ListBox listOstukorv;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.Button btnLisaOstukorvi;
        private System.Windows.Forms.Button btnMuu;
    }
}