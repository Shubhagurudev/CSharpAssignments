using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Order:Customer
    {
		private int oid;

		public int OId
		{
			get { return oid; }
			set { oid = value; }
		}

		private DateTime odt;

		public DateTime ODT
		{
			get { return odt; }
			set { odt = value; }
		}

        public int CalcPrice(int Qty, int Price)
        {
            int total = Qty * Price;
            return total;
        }

		public void BookOrder(int id, DateTime od, int total)
		{
			Console.WriteLine($"order id = {OId}");
		Console.WriteLine($"customer = {base.CId}");
		Console.WriteLine($"od = {ODT}");
		

		//Console.WriteLine($"pm = {Paymode}");
		

	     }

	}
}
