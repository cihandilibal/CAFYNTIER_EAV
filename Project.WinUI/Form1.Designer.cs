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
			this.txtUrunIsim = new System.Windows.Forms.TextBox();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.txtUrunFiyat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lstKategori = new System.Windows.Forms.ListBox();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnListele = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtKategoriIsim
			// 
			this.txtKategoriIsim.Location = new System.Drawing.Point(26, 58);
			this.txtKategoriIsim.Name = "txtKategoriIsim";
			this.txtKategoriIsim.Size = new System.Drawing.Size(113, 22);
			this.txtKategoriIsim.TabIndex = 0;
			// 
			// txtUrunIsim
			// 
			this.txtUrunIsim.Location = new System.Drawing.Point(28, 174);
			this.txtUrunIsim.Name = "txtUrunIsim";
			this.txtUrunIsim.Size = new System.Drawing.Size(111, 22);
			this.txtUrunIsim.TabIndex = 2;
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(28, 115);
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(111, 22);
			this.txtAciklama.TabIndex = 3;
			// 
			// txtUrunFiyat
			// 
			this.txtUrunFiyat.Location = new System.Drawing.Point(28, 235);
			this.txtUrunFiyat.Name = "txtUrunFiyat";
			this.txtUrunFiyat.Size = new System.Drawing.Size(111, 22);
			this.txtUrunFiyat.TabIndex = 4;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(24, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Ürün";
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(26, 212);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Fiyat";
			// 
			// lstKategori
			// 
			this.lstKategori.FormattingEnabled = true;
			this.lstKategori.ItemHeight = 16;
			this.lstKategori.Location = new System.Drawing.Point(204, 24);
			this.lstKategori.Name = "lstKategori";
			this.lstKategori.Size = new System.Drawing.Size(648, 500);
			this.lstKategori.TabIndex = 6;
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(17, 303);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(102, 43);
			this.btnEkle.TabIndex = 7;
			this.btnEkle.Text = "EKLE";
			this.btnEkle.UseVisualStyleBackColor = true;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(17, 500);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(102, 43);
			this.btnGuncelle.TabIndex = 8;
			this.btnGuncelle.Text = "GÜNCELLE";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(17, 370);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(102, 43);
			this.btnSil.TabIndex = 9;
			this.btnSil.Text = "SİL";
			this.btnSil.UseVisualStyleBackColor = true;
			// 
			// btnListele
			// 
			this.btnListele.Location = new System.Drawing.Point(17, 436);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(102, 43);
			this.btnListele.TabIndex = 10;
			this.btnListele.Text = "LİSTELE";
			this.btnListele.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 608);
			this.Controls.Add(this.btnListele);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.lstKategori);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUrunFiyat);
			this.Controls.Add(this.txtAciklama);
			this.Controls.Add(this.txtUrunIsim);
			this.Controls.Add(this.txtKategoriIsim);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox txtKategoriIsim;
		private System.Windows.Forms.TextBox txtUrunIsim;
		private System.Windows.Forms.TextBox txtAciklama;
		private System.Windows.Forms.TextBox txtUrunFiyat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lstKategori;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnListele;
	}
}

