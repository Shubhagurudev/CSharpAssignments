using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
	public enum PM
	{
		cash,
		upi,
		debt,
		netbanking,
		credit
	}
    public class Orders:Customer
    {
		private int vid;
		public int Oid
		{
			get { return vid; }
			set { vid = value; }
		}

		private DateTime vdt;

		public DateTime Odt
		{
			get { return vdt; }
			set { vdt = value; }
		}

		private PM mode;

		public PM pmode
		{
			get { return mode; }
			set { mode = value; }
		}

		public void BookOrder(int Cid,DateTime od,PM pmode, float qty, decimal price)

		{
            Console.WriteLine(	"sucess");
            Console.WriteLine(	"o booked for{cid} on{od} mode{mode} for{qty} at {price}");
        }

        decimal amt = base.calctotal();



	}
}
