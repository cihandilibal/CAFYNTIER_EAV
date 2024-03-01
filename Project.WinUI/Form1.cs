using Project.BLL.DesingPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.WinUI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        CategoryRepository _categoryRepository;
		

        public Form1()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			KategoriListele();
		}

		void KategoriListele()
		{
			lstKategori.DataSource = _categoryRepository.Select<CategoryVM>(x => new CategoryVM
			{
				ID = x.ID,
				CategoryName = x.CategoryName,
				Description = x.Description,
				Products = x.Products

			}).ToList();
		}

		private void btnListele_Click(object sender, EventArgs e)
		{
			KategoriListele();
		}

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
			_categoryRepository.Add(c);
			KategoriListele();
		}

		CategoryVM _secili;

		private void lstKategori_Click(object sender, EventArgs e)
		{
			if (lstKategori.SelectedIndex > -1)
			{
				_secili = (CategoryVM)lstKategori.SelectedItem;
				txtKategoriIsim.Text = _secili.CategoryName;
				txtAciklama.Text = _secili.Description;
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (_secili !=null)
			{
				Category silinenKategori = _categoryRepository.Find(_secili.ID);
				_categoryRepository.Delete(silinenKategori);
				KategoriListele();
				_secili = null;
				txtKategoriIsim.Text = txtAciklama.Text = null;
			}
			else
			{
				MessageBox.Show("Lütfen bir kategori seçin!","KATEGORİ SEÇ");
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (_secili != null)
			{
				Category guncellenenKategori = _categoryRepository.Find(_secili.ID);
				guncellenenKategori.CategoryName = txtKategoriIsim.Text;
				guncellenenKategori.Description = txtAciklama.Text;
				_categoryRepository.Update(guncellenenKategori);
				KategoriListele();
			    _secili = null;
				txtKategoriIsim.Text = txtAciklama.Text = null;
			}
			MessageBox.Show("Lütfen bir kategori seçin!","KATEGORİ SEÇ");
		}

		private void btnForm2_Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.ShowDialog();
		}
	}
}
