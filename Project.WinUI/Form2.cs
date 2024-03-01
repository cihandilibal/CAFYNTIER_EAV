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
	public partial class Form2 : Form
	{
		CategoryRepository _categoryRep;
		ProductRepository _productRep;
		EntityAttributeRepository _entityAttributeRep;
		ProductAttributeRepository _productAttributeRep;

		public Form2()
		{
			InitializeComponent();
			_categoryRep = new CategoryRepository();
			_productRep = new ProductRepository();
			_entityAttributeRep = new EntityAttributeRepository();
			_productAttributeRep = new ProductAttributeRepository();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			KategoriListele();
			UrunListele();
		}

		void KategoriListele()
		{
			cmbKategoriler.DataSource = _categoryRep.Select(x => new CategoryVM
			{
				ID = x.ID,
				CategoryName = x.CategoryName,
				Description = x.Description				 
			}).ToList();

			cmbKategoriler.DisplayMember = "CategoryName";
			cmbKategoriler.ValueMember = "ID";
		}

		void UrunListele()
		{
			lstUrun.DataSource = _productRep.Select(x => new ProductVM
			{
				ID = x.ID,
				ProductName = x.ProductName,
				UnitPrice = x.UnitPrice,
				CategoryName = x.Category == null ? "Kategorisi Yok": x.Category.CategoryName, CategoryID = x.CategoryID

			}).ToList();
		}

		ProductVM _secilen;

		private void lstUrun_Click(object sender, EventArgs e)
		{
			if (lstUrun.SelectedIndex > -1)
			{
				_secilen = lstUrun.SelectedItem as ProductVM;
				txtIsim.Text = _secilen.ProductName;
				txtFiyat.Text = _secilen.UnitPrice.ToString();
				cmbKategoriler.SelectedValue = _secilen.CategoryID != null ? _secilen.CategoryID.Value : -1;
			}
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				Product p = new Product();
				p.ProductName = txtIsim.Text;
				p.UnitPrice = Convert.ToDecimal(txtFiyat.Text);
				if (cmbKategoriler.SelectedIndex > -1 ) p.CategoryID = Convert.ToInt32(cmbKategoriler.SelectedValue);

				_productRep.Add(p);
				UrunListele();
			
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (_secilen != null)
			{
				Product silinenUrun = _productRep.Find(_secilen.ID);
				_productRep.Delete(silinenUrun);
				UrunListele();
				_secilen = null;
				txtIsim.Text = txtFiyat.Text = null;
				cmbKategoriler.SelectedIndex = -1;
			}
			else
			{
				MessageBox.Show("Lütfen bir ürün seçin!","ÜRÜN SEÇ");
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				if (_secilen != null)
				{
					Product guncellenenUrun = _productRep.Find(_secilen.ID);
					guncellenenUrun.ProductName = txtIsim.Text;
					guncellenenUrun.UnitPrice = Convert.ToDecimal(txtFiyat.Text);
					if (cmbKategoriler.SelectedIndex > -1) guncellenenUrun.CategoryID = Convert.ToInt32(cmbKategoriler.SelectedValue);
					_productRep.Update(guncellenenUrun);
					_secilen = null;
					txtIsim.Text = txtFiyat.Text = null;
					cmbKategoriler.SelectedIndex = -1;
					
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
	}
}
