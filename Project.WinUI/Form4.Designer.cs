namespace Project.WinUI
{
    partial class Form4
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
            this.cmbOzellikler = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstUrunOzellikleri = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunOzellik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbOzellikler
            // 
            this.cmbOzellikler.FormattingEnabled = true;
            this.cmbOzellikler.Location = new System.Drawing.Point(81, 135);
            this.cmbOzellikler.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOzellikler.Name = "cmbOzellikler";
            this.cmbOzellikler.Size = new System.Drawing.Size(120, 21);
            this.cmbOzellikler.TabIndex = 36;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(101, 262);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 35);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(104, 331);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(76, 35);
            this.btnGuncelle.TabIndex = 33;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(101, 194);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(76, 35);
            this.btnEkle.TabIndex = 32;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstUrunOzellikleri
            // 
            this.lstUrunOzellikleri.FormattingEnabled = true;
            this.lstUrunOzellikleri.Location = new System.Drawing.Point(233, 13);
            this.lstUrunOzellikleri.Margin = new System.Windows.Forms.Padding(2);
            this.lstUrunOzellikleri.Name = "lstUrunOzellikleri";
            this.lstUrunOzellikleri.Size = new System.Drawing.Size(487, 407);
            this.lstUrunOzellikleri.TabIndex = 31;
            this.lstUrunOzellikleri.Click += new System.EventHandler(this.lstUrunOzellikleri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "DegerIsim";
            // 
            // txtUrunOzellik
            // 
            this.txtUrunOzellik.Location = new System.Drawing.Point(94, 72);
            this.txtUrunOzellik.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunOzellik.Name = "txtUrunOzellik";
            this.txtUrunOzellik.Size = new System.Drawing.Size(86, 20);
            this.txtUrunOzellik.TabIndex = 27;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbOzellikler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstUrunOzellikleri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunOzellik);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOzellikler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstUrunOzellikleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunOzellik;
    }
}