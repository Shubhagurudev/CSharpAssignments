using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjcitLibrary
{
    public class Customer:Discount
    {
		public int id;

		public int Cid
		{
			get { return id; }
			set { id = value; }
		}
		public string cname;

		public string Cname
		{
			get { return cname; }
			set { cname = value; }
		}

		 



	}
}
