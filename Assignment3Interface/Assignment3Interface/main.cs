using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Assignment3Interface
{
    internal class main
    {
        static void Main(string[] args)
        {
            Products[] p = new Products[2];

            p[0] = new Products();

            p[0].ProdId = 101;
            p[0].ProdName = "Pizza";
            p[0].Qty = 3;
            p[0].Price = 150;

            p[1] = new Products();

            p[1].ProdId = 102;
            p[1].ProdName = "Pani Puri";
            p[1].Qty = 2;
            p[1].Price = 35;

            Customer c = new Customer();
            c.CId = 1001;

            Order o = new Order();
            o.OId = 1;
            o.ODT = DateTime.Now;

            Cart cart = new Cart(2);
            
            
            
            
            
            cart.AddToCart(p[0].ProdId, p[0].ProdName, p[0].Qty, p[0].Price);

            cart.AddToCart(p[1].ProdId, p[1].ProdName, p[1].Qty, p[1].Price);

            o.BookOrder(c.CId, o.ODT);
        }
    }
}
