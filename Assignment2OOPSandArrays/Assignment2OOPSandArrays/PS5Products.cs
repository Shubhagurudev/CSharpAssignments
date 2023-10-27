using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOPSandArrays
{
    public class PS5Products
    {
        public  int prodId;

        public int productId
        {
            get; //set {; }//prodId = value; }
            set; //get {; }//return prodId; }
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


        //static int prodId = 1;

        //public int productId
        //{

        //    //set { productId = prodId; }
        //    //get { return productId; }
        //    get; set;
        //}

        ////string prodName;

        //public string productName
        //{
        //    //set { prodName = value; }
        //    //get { return prodName; }get
        //    get; set;
        //}

        ////float prodPrice;
        //public float productPrice
        //{
        //    //set { prodPrice = value; }
        //    //get { return prodPrice; }
        //    get;set;
        //}

        ////string prodMeasure;
        //public string UnitOfMeasurement
        //{
        //    //set { prodMeasure = value; }
        //    //get { return prodMeasure; }
        //    get; set;
        //}

        ////float prodQty;
        //public float productQuantity
        //{
        //    //set { prodQty = value; }
        //    //get { return prodQty; }
        //    get; set;
        //}

        public PS5Products()
        {

            prodId = prodId + 1;
            productId = prodId;
        }
    }
}
