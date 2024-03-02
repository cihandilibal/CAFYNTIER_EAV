namespace Project.WinUI
{
    partial class Form3
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
            this.btnForm4 = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstOzellikler = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtOzellikIsim = new System.Windows.Forms.TextBox();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnForm4
            // 
            this.btnForm4.BackColor = System.Drawing.Color.LimeGreen;
            this.btnForm4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForm4.Location = new System.Drawing.Point(83, 376);
            this.btnForm4.Margin = new System.Windows.Forms.Padding(2);
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(94, 42);
            this.btnForm4.TabIndex = 20;
            this.btnForm4.Text = "Form4";
            this.btnForm4.UseVisualStyleBackColor = false;
            this.btnForm4.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(92, 242);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 35);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(95, 311);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(76, 35);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(92, 174);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(76, 35);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstOzellikler
            // 
            this.lstOzellikler.FormattingEnabled = true;
            this.lstOzellikler.Location = new System.Drawing.Point(224, -7);
            this.lstOzellikler.Margin = new System.Windows.Forms.Padding(2);
            this.lstOzellikler.Name = "lstOzellikler";
            this.lstOzellikler.Size = new System.Drawing.Size(487, 407);
            this.lstOzellikler.TabIndex = 16;
            this.lstOzellikler.Click += new System.EventHandler(this.lstOzellikler_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(92, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ozellik";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(92, 66);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(84, 20);
            this.txtAciklama.TabIndex = 13;
            // 
            // txtOzellikIsim
            // 
            this.txtOzellikIsim.Location = new System.Drawing.Point(91, 20);
            this.txtOzellikIsim.Margin = new System.Windows.Forms.Padding(2);
            this.txtOzellikIsim.Name = "txtOzellikIsim";
            this.txtOzellikIsim.Size = new System.Drawing.Size(86, 20);
            this.txtOzellikIsim.TabIndex = 12;
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(72, 115);
            this.cmbUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(120, 21);
            this.cmbUrunler.TabIndex = 26;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.btnForm4);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstOzellikler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtOzellikIsim);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstOzellikler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtOzellikIsim;
        private System.Windows.Forms.ComboBox cmbUrunler;
    }
}