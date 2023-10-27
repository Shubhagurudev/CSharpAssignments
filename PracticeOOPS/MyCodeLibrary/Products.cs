using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Products
    {
        private int pid;

        public int Prodid
        {
            get { return pid; }
            set { pid = value; }
        }

        private string pname;
        public string Prodname
        {
            get { return pname; }
            set { pname = value; }
        }

        private decimal price;
        public decimal Prodprice
        {
            get { return price; }
            set { price = value; }
        }

        private string uom;
        public string UoM
        {
            get { return uom; }
            set { uom = value; }
        }

        private float qty;

        public float ProdQty
        {
            get { return qty; }
            set { qty = value; }
        }

        public decimal calctotal()
        {
            decimal total = Prodprice * Convert.ToDecimal(ProdQty);
            return total;
        }

    }
}
