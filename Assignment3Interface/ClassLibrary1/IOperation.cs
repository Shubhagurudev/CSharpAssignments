using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassLibrary1
{
    internal interface IOperation
    {
        void AddToCart(int prodid, string prodname, int qty, int price);
        void PaymentGateway(int amt);

        void BuyNow();
    }

    public class cart
    {
        
        public int size {  get; set; }
        public int item { get; set; }
    }
    public class one : cart,IOperation
    {
        public void AddToCart(int prodid, string prodname, int qty, int price)
        {
            Console.WriteLine($"{prodid} added , quantity = {qty}, name = {prodname} price = {price}");
            
        }

        public void BuyNow()
        {
            Console.WriteLine("item ="+ base.item );
        }

        public void PaymentGateway(int amt)
        {
            Console.WriteLine(  "pay");
        }
    }


    // public AddToCart(int prodid, string city, int qty, int price);

}
