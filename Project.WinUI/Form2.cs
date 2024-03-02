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

namespace Project.WinUI
{
	public partial class Form2 : Form
	{
		CategoryRepository _crep;
		ProductRepository _prep;
		

		public Form2()
		{
			InitializeComponent();
			_crep = new CategoryRepository();
			_prep = new ProductRepository();
			
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			KategoriListele();
			UrunListele();
		}

		private void KategoriListele()
		{
			cmbKategoriler.DataSource = _crep.GetActives();
            cmbKategoriler.DisplayMember = "CategoryName";
            cmbKategoriler.SelectedIndex = -1;

        }

		private void UrunListele()
		{
            lstUrunler.DataSource = _prep.GetActives();
            lstUrunler.DisplayMember = "ProductName";
            lstUrunler.SelectedIndex = -1;
        }

		Product p;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedIndex > -1)
            {
                Product p = new Product();
                p.ProductName = txtIsim.Text;
                p.UnitPrice = Convert.ToDecimal(txtFiyat.Text);
                _prep.Add(p);
                UrunListele();

            }
            else
            {
                MessageBox.Show("Lütfen Kategori Ismi Girin!", "ISİM GİRİLMEDİ");
                return;

            }
        }

        private void lstUrunler_Click(object sender, EventArgs e)
        {
			if (lstUrunler.SelectedIndex > -1)
			{
				p = lstUrunler.SelectedItem as Product;
				txtIsim.Text = p.ProductName;
				txtFiyat.Text = p.UnitPrice.ToString();
				
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedIndex > -1)
            {
				
				_prep.Delete(p);
                p = null;
                UrunListele();
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
			
			
			if (lstUrunler.SelectedIndex > -1)
			{
				
				p.ProductName = txtIsim.Text;
				p.UnitPrice = Convert.ToDecimal(txtFiyat.Text);
			    _prep.Update(p);
				p = null;
				txtIsim.Text = txtFiyat.Text = null;
				cmbKategoriler.SelectedIndex = -1;
					
			}
			else
			{
                MessageBox.Show("Lütfen bir ürün seçin!", "ÜRÜN SEÇ");
            }
			
			
		}

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
    }
}
