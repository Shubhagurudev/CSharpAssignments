using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOPSandArrays
{
    internal class PS2Products
    {
        int prodId ;

        public int productId
        {
            set { prodId = value; }
            get { return prodId; }
        }

        string prodName;

        public string productName
        {
            set { prodName = value; }
            get { return prodName; }
        }

        float prodPrice;
        public float productPrice
        {
            set { prodPrice = value; }
            get { return prodPrice; }
        }

       string prodMeasure;
        public string UnitOfMeasurement
        {
            set { prodMeasure = value; }
            get { return prodMeasure; }
        }

        float prodQty;
        public float productQuantity
        {
            set { prodQty = value; }
            get { return prodQty; }
        }

    }
}






























//        static int Prodid = 0;
//        public int ProductId { get; set; }
//        public string ProductName { get; set; }

//        public int Price { get; set; }

//        public string UnitOfMeasurement { get; set; }

//        public int Qty { get; set; }

//        public Products()
//        {
//            Prodid = Prodid + 1;
//            ProductId = Prodid;
//        }
//    }
//}

//private int prodId;
//







