namespace Project.WinUI
{
    partial class Form1
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
			this.txtKategoriIsim = new System.Windows.Forms.TextBox();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lstKategori = new System.Windows.Forms.ListBox();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnListele = new System.Windows.Forms.Button();
			this.btnForm2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtKategoriIsim
			// 
			this.txtKategoriIsim.Location = new System.Drawing.Point(26, 58);
			this.txtKategoriIsim.Name = "txtKategoriIsim";
			this.txtKategoriIsim.Size = new System.Drawing.Size(113, 22);
			this.txtKategoriIsim.TabIndex = 0;
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(28, 115);
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(111, 22);
			this.txtAciklama.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(24, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Kategori";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(28, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Açıklama";
			// 
			// lstKategori
			// 
			this.lstKategori.FormattingEnabled = true;
			this.lstKategori.ItemHeight = 16;
			this.lstKategori.Location = new System.Drawing.Point(204, 24);
			this.lstKategori.Name = "lstKategori";
			this.lstKategori.Size = new System.Drawing.Size(648, 500);
			this.lstKategori.TabIndex = 6;
			this.lstKategori.Click += new System.EventHandler(this.lstKategori_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(37, 263);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(102, 43);
			this.btnEkle.TabIndex = 7;
			this.btnEkle.Text = "EKLE";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(37, 389);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(102, 43);
			this.btnGuncelle.TabIndex = 8;
			this.btnGuncelle.Text = "GÜNCELLE";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(37, 327);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(102, 43);
			this.btnSil.TabIndex = 9;
			this.btnSil.Text = "SİL";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnListele
			// 
			this.btnListele.Location = new System.Drawing.Point(37, 202);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(102, 43);
			this.btnListele.TabIndex = 10;
			this.btnListele.Text = "LİSTELE";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// btnForm2
			// 
			this.btnForm2.BackColor = System.Drawing.Color.LimeGreen;
			this.btnForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnForm2.Location = new System.Drawing.Point(642, 544);
			this.btnForm2.Name = "btnForm2";
			this.btnForm2.Size = new System.Drawing.Size(126, 52);
			this.btnForm2.TabIndex = 11;
			this.btnForm2.Text = "Form2";
			this.btnForm2.UseVisualStyleBackColor = false;
			this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 608);
			this.Controls.Add(this.btnForm2);
			this.Controls.Add(this.btnListele);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.lstKategori);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAciklama);
			this.Controls.Add(this.txtKategoriIsim);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox txtKategoriIsim;
		private System.Windows.Forms.TextBox txtAciklama;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox lstKategori;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnListele;
		private System.Windows.Forms.Button btnForm2;
	}
}

