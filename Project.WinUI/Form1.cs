using Project.BLL.DesingPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        CategoryRepository _crep;
		

        public Form1()
        {
            InitializeComponent();
            _crep = new CategoryRepository();
        }

		private void Form1_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

		private void KategoriListele()
		{
			lstKategoriler.DataSource = _crep.GetActives();
            lstKategoriler.DisplayMember = "CategoryName";
            lstKategoriler.SelectedIndex = -1;
        }
		Category c;
		private void btnEkle_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtKategoriIsim.Text.Trim()))
			{
				MessageBox.Show("Lütfen Kategori Ismi Girin!","ISİM GİRİLMEDİ");
				return;
			}
			Category c = new Category
			{
				CategoryName = txtKategoriIsim.Text,
				Description = txtAciklama.Text
			};
			_crep.Add(c);
			KategoriListele();
		}

        private void lstKategoriler_Click(object sender, EventArgs e)
        {
			if (lstKategoriler.SelectedIndex > -1)
			{
				c = lstKategoriler.SelectedItem as Category;
				txtKategoriIsim.Text = c.CategoryName;
				txtAciklama.Text = c.Description;
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstKategoriler.SelectedIndex > -1 )
			{
				_crep.Delete(c);
                c = null;
                KategoriListele();
			    txtKategoriIsim.Text = txtAciklama.Text = null;
			}
			else
			{
				MessageBox.Show("Lütfen bir kategori seçin!","KATEGORİ SEÇ");
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (lstKategoriler.SelectedIndex > -1)
			{
	            c.CategoryName = txtKategoriIsim.Text;
				c.Description = txtAciklama.Text;
				_crep.Update(c);
				KategoriListele();
			    c = null;
				txtKategoriIsim.Text = txtAciklama.Text = null;
			}
			else MessageBox.Show("Lütfen bir kategori seçin!", "KATEGORİ SEÇ");

        }

		private void btnForm2_Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.ShowDialog();
		}

       
    }
}
