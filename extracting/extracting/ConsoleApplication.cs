using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SjcitLibrary;
using static SjcitLibrary.Order;

namespace extracting
{
    public class ConsoleApplication
    {
        static void Main(string[] args)
        {

            Customer c = new Customer();
            Console.WriteLine("enter customer id");
            c.Cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer name");
            c.Cname = Console.ReadLine();

            Products p = new Products();
            Console.WriteLine("enter pid");
            p.Pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter pname");
            p.Pname = Console.ReadLine();
            Console.WriteLine("enter pQty");
            p.Qty = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter price");
            p.Price = Convert.ToDecimal(Console.ReadLine());

            p.CalculateTotal(p.Qty,p.price);
                       
            Order o = new Order();
            Console.WriteLine("enter order id");
            o.Oid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter order date");
            o.Odt = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter pay mode");
            o.Pmode = (PaymentMode)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(  "*******ORDER DETAILS************");
            o.OrderDetails(o.Oid,o.Odt,o.Pmode,p.Pid,p.Pname,p.Qty,p.Price); 

            Discount d = new Discount();
            d.CalculateDiscount(p.Qty,p.Price);

            Console.ReadLine();
        }
    }
}
