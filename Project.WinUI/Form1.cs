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



			});
		}
	}
}
