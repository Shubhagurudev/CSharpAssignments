using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Products
    {
		private int pid;

		public int ProdId
		{
			get { return pid; }
			set { pid = value; }
		}

		private string pname;

		public string ProdName
		{
			get { return pname; }
			set { pname = value; }
		}

        private int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        private int price;

		public int Price
		{
			get { return price; }
			set { price = value; }
		}

		




	}
}
