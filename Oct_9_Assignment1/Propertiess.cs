using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct_9_Assignment1
{
	internal class Propertiess

	{

		public int m;

		public int Maths
		{
			get { return m; }
			set { m = value; }
		}

		public int s;

		public int Science
		{
			get { return s; }
			set { s = value; }
		}

		public int e;
		public int English
		{
			get { return e; }
			set { e = value; }
		}

		public int Calculate(int m, int s, int e)
		{
			int total = m + s + e;
			return total;
		}
	}
}




