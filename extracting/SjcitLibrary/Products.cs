using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SjcitLibrary
{
	public class Products
	{
		public int pid;

		public int Pid
		{
			get { return pid; }
			set { pid = value; }
		}

		public string pname;

		public string Pname
		{
			get { return pname; }
			set { pname = value; }
		}

		public float qty;

		public float Qty
		{
			get { return qty; }
			set { qty = value; }
		}

		public decimal price;

		public decimal Price
		{
			get { return price; }
			set { price = value; }
		}

		public decimal CalculateTotal(float qty, decimal price)
		{
			decimal Totalamt = Convert.ToDecimal(qty) * price;
			return Totalamt;

		}

	}
}
