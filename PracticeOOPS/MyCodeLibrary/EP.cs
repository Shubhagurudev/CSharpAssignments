using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class EP:Products// i also want  properties that products have,  for my electronics products

		// sequence of compilation is decided by project dependency
    {
		private DateTime mgfDAte;

		public DateTime MD
		{
			get { return mgfDAte; }
			set { mgfDAte = value; }
		}

		private int w;

		public int Watt
		{
			get { return w; }
			set { w = value; }
		}

		public decimal calcdisc()
		{
			decimal afterDis = 0;
			decimal amt = base.calctotal();
			if(amt>1000 && amt < 5000)
			{
				decimal discount = amt * Convert.ToDecimal(0.2);
			}
			else if(amt>5000 && amt < 10000)
			{
				decimal discount = amt * Convert.ToDecimal(0.5);
				afterDis = amt - discount;
			}
			else
			{
				afterDis = amt;

			}
			return afterDis;
		}



	}
}
