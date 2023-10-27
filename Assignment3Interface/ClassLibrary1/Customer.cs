using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer:Products
    {
		private int cid;

		public int CId
		{
			get { return cid; }
			set { cid = value; }
		}

		private string cname;

		public string Cname
		{
			get { return cname; }
			set { cname = value; }
		}


	}
}
