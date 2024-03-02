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
    public partial class Form4 : Form
    {
        EntityAttributeRepository _erep;
        ProductAttributeRepository _prop;

        public Form4()
        {
            InitializeComponent();
            _erep = new EntityAttributeRepository();
            _prop = new ProductAttributeRepository();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            OzellikListele();
            DegerListele();

        }
        private void OzellikListele()
        {
            cmbOzellikler.DataSource = _erep.GetActives();
            cmbOzellikler.DisplayMember = "AttributeName";
            cmbOzellikler.SelectedIndex = -1;
        }
        private void DegerListele()
        {
            lstUrunOzellikleri.DataSource = _prop.GetActives();
            lstUrunOzellikleri.DisplayMember = "Value";
            lstUrunOzellikleri.SelectedIndex = -1;
        }
        ProductAttribute pa;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbOzellikler.SelectedIndex > -1)
            {
                ProductAttribute pa = new ProductAttribute();
                pa.Value = txtUrunOzellik.Text;
                _prop.Add(pa);
                DegerListele();

            }
            else
            {
                MessageBox.Show("Lütfen özellik Ismi Girin!", "ISİM GİRİLMEDİ");
                return;

            }


        }

        private void lstUrunOzellikleri_Click(object sender, EventArgs e)
        {
            if (lstUrunOzellikleri.SelectedIndex > -1)
            {
                pa = lstUrunOzellikleri.SelectedItem as ProductAttribute;
                txtUrunOzellik.Text = pa.Value;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrunOzellikleri.SelectedIndex > -1)
            {
               _prop.Delete(pa);
                pa = null;
                DegerListele();
                txtUrunOzellik.Text = null;
                cmbOzellikler.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün özelliği seçin!", "ÜRÜN ÖZELLİGİ SEÇ");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrunOzellikleri.SelectedIndex > -1)
            {

                pa.Value= txtUrunOzellik.Text;
                _prop.Update(pa);
                pa = null;
                txtUrunOzellik.Text =  null;
                cmbOzellikler.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Lütfen bir ürün özelliği seçin!", "ÜRÜN ÖZELLİGİ SEÇ");
            }
        }
    }

}
