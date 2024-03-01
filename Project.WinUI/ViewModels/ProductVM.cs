using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.WinUI.ViewModels
{
	public class ProductVM
	{
        public int ID { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public string CategoryName { get; set; }

        public int? CategoryID { get; set; }

		public override string ToString()
		{
			return $"{ProductName}, Fiyat=> {UnitPrice:C2}, Category=> {CategoryName}";
		}
	}
}
