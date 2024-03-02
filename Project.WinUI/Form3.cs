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
    public partial class Form3 : Form
    {
        ProductRepository _prep;
        EntityAttributeRepository _erep;

        public Form3()
        {
            InitializeComponent();
            _erep = new EntityAttributeRepository();
            _prep = new ProductRepository();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
              UrunListele();
              OzellikListele();
        }
        private void UrunListele()
        {
            cmbUrunler.DataSource = _prep.GetActives();
            cmbUrunler.DisplayMember = "ProductName";
            cmbUrunler.SelectedIndex = -1;

        }
        private void OzellikListele()
        {
            lstOzellikler.DataSource = _erep.GetActives();
            lstOzellikler.DisplayMember = "AttributeName";
            lstOzellikler.SelectedIndex = -1;
        }

        
        EntityAttribute et;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbUrunler.SelectedIndex > -1)
            {
                EntityAttribute et = new EntityAttribute();
                et.AttributeName = txtOzellikIsim.Text;
                et.Description = txtAciklama.Text;
                _erep.Add(et);
                OzellikListele();

            }
            else
            {
                MessageBox.Show("Lütfen ürün Ismi Girin!", "ISİM GİRİLMEDİ");
                return;

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstOzellikler.SelectedIndex > -1)
            {

                _erep.Delete(et);
                et = null;
                OzellikListele();
                txtOzellikIsim.Text = txtAciklama.Text = null;
                cmbUrunler.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lütfen bir özellik seçin!", "ÖZELLİK SEÇ");
            }
        }
        private void lstOzellikler_Click(object sender, EventArgs e)
        {
            if (lstOzellikler.SelectedIndex > -1)
            {
                et = lstOzellikler.SelectedItem as EntityAttribute;
                txtOzellikIsim.Text = et.AttributeName;
                txtAciklama.Text = et.Description;

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (lstOzellikler.SelectedIndex > -1)
            {

                et.AttributeName = txtOzellikIsim.Text;
                et.Description = txtAciklama.Text;
                _erep.Update(et);
                OzellikListele();
                et = null;
                txtOzellikIsim.Text = txtAciklama.Text = null;
                cmbUrunler.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Lütfen bir özellik seçin!", "ÖZELLİK SEÇ");
            }
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        
    }
}
