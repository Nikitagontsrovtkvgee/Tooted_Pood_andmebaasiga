namespace Pood_andmebaasiga
{
    partial class Tooded
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
            this.txtNimetus = new System.Windows.Forms.TextBox();
            this.txtKogus = new System.Windows.Forms.TextBox();
            this.txtHind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKategooria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.txtNimetus.Location = new System.Drawing.Point(177, 188);
            this.txtNimetus.Name = "txtNimetus";
            this.txtNimetus.Size = new System.Drawing.Size(100, 20);
            this.txtNimetus.TabIndex = 0;
            // 
            // txtKogus
            // 
            this.txtKogus.Location = new System.Drawing.Point(319, 188);
            this.txtKogus.Name = "txtKogus";
            this.txtKogus.Size = new System.Drawing.Size(100, 20);
            this.txtKogus.TabIndex = 1;
            // 
            // txtHind
            // 
            this.txtHind.Location = new System.Drawing.Point(458, 188);
            this.txtHind.Name = "txtHind";
            this.txtHind.Size = new System.Drawing.Size(100, 20);
            this.txtHind.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toote nimetus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kogus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hind";
            // 
            // cmbKategooria
            // 
            this.cmbKategooria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategooria.FormattingEnabled = true;
            this.cmbKategooria.Location = new System.Drawing.Point(129, 80);
            this.cmbKategooria.Name = "cmbKategooria";
            this.cmbKategooria.Size = new System.Drawing.Size(121, 21);
            this.cmbKategooria.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategooria";
            // 
            // picPilt
            // 
            this.picPilt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPilt.Location = new System.Drawing.Point(671, 270);
            this.picPilt.Name = "picPilt";
            this.picPilt.Size = new System.Drawing.Size(150, 150);
            this.picPilt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPilt.TabIndex = 8;
            this.picPilt.TabStop = false;
            // 
            // dataGridTooted
            // 
            this.dataGridTooted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTooted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTooted.Location = new System.Drawing.Point(36, 229);
            this.dataGridTooted.Name = "dataGridTooted";
            this.dataGridTooted.ReadOnly = true;
            this.dataGridTooted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTooted.Size = new System.Drawing.Size(600, 300);
            this.dataGridTooted.TabIndex = 9;
            this.dataGridTooted.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTooted_CellClick);
            // 
            // btnLisa
            // 
            this.btnLisa.Location = new System.Drawing.Point(605, 188);
            this.btnLisa.Name = "btnLisa";
            this.btnLisa.Size = new System.Drawing.Size(75, 23);
            this.btnLisa.TabIndex = 10;
            this.btnLisa.Text = "Lisa";
            this.btnLisa.UseVisualStyleBackColor = true;
            this.btnLisa.Click += new System.EventHandler(this.btnLisa_Click);
            // 
            // btnUuenda
            // 
            this.btnUuenda.Location = new System.Drawing.Point(686, 188);
            this.btnUuenda.Name = "btnUuenda";
            this.btnUuenda.Size = new System.Drawing.Size(75, 23);
            this.btnUuenda.TabIndex = 11;
            this.btnUuenda.Text = "Uuenda";
            this.btnUuenda.UseVisualStyleBackColor = true;
            this.btnUuenda.Click += new System.EventHandler(this.btnUuenda_Click);
            // 
            // btnKustuta
            // 
            this.btnKustuta.Location = new System.Drawing.Point(767, 188);
            this.btnKustuta.Name = "btnKustuta";
            this.btnKustuta.Size = new System.Drawing.Size(75, 23);
            this.btnKustuta.TabIndex = 12;
            this.btnKustuta.Text = "Kustuta";
            this.btnKustuta.UseVisualStyleBackColor = true;
            this.btnKustuta.Click += new System.EventHandler(this.btnKustuta_Click);
            // 
            // btnOtsiFail
            // 
            this.btnOtsiFail.Location = new System.Drawing.Point(845, 270);
            this.btnOtsiFail.Name = "btnOtsiFail";
            this.btnOtsiFail.Size = new System.Drawing.Size(75, 23);
            this.btnOtsiFail.TabIndex = 13;
            this.btnOtsiFail.Text = "Otsi pilt";
            this.btnOtsiFail.UseVisualStyleBackColor = true;
            this.btnOtsiFail.Click += new System.EventHandler(this.btnOtsiPilt_Click);
            // 
            // btnLisaKategooria
            // 
            this.btnLisaKategooria.Location = new System.Drawing.Point(24, 78);
            this.btnLisaKategooria.Name = "btnLisaKategooria";
            this.btnLisaKategooria.Size = new System.Drawing.Size(87, 23);
            this.btnLisaKategooria.TabIndex = 14;
            this.btnLisaKategooria.Text = "Lisa kategooria";
            this.btnLisaKategooria.UseVisualStyleBackColor = true;
            this.btnLisaKategooria.Click += new System.EventHandler(this.btnLisaKategooria_Click);
            // 
            // btnKustutaKategooria
            // 
            this.btnKustutaKategooria.Location = new System.Drawing.Point(24, 118);
            this.btnKustutaKategooria.Name = "btnKustutaKategooria";
            this.btnKustutaKategooria.Size = new System.Drawing.Size(87, 23);
            this.btnKustutaKategooria.TabIndex = 15;
            this.btnKustutaKategooria.Text = "Kustuta kategooria";
            this.btnKustutaKategooria.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbKategooria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHind);
            this.Controls.Add(this.txtKogus);
            this.Controls.Add(this.txtNimetus);
            this.Name = "Tooded";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tooded";
            this.Load += new System.EventHandler(this.Tooded_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTooted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNimetus;
        private System.Windows.Forms.TextBox txtKogus;
        private System.Windows.Forms.TextBox txtHind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKategooria;
        private System.Windows.Forms.Label label4;
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

