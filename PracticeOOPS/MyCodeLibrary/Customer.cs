using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Customer:EP
    {
		private int id;

		public int Cid
		{
			get { return id; }
			set { id = value; }
		}

		private string n;

		public string Cname
		{
			get { return n; }
			set { n = value; }
		}

		private int myVar;

		public int MyProperty
		{
			get { return myVar; }
			set { myVar = value; }
		}

        public decimal calctotal()
        {
            decimal total = Prodprice * Convert.ToDecimal(ProdQty);
            return total;
        }



    }
}
