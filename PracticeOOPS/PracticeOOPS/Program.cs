using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MyCodeLibrary;

namespace PracticeOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calci();

            //simpleExample();

            EP ep = new EP();   
            Console.WriteLine(  "pid");
            ep.Prodid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price");
            ep.Prodprice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("qty");
            ep.ProdQty = Convert.ToSingle(Console.ReadLine());
            Customer c = new Customer();
            Console.WriteLine("cid");
            c.Cid = Convert.ToInt32(Console.ReadLine());

            Orders o = new Orders();
            Console.WriteLine("dte");
            o.Odt = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("pay mode");
            o.pmode = (PM)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"pmode");
            o.BookOrder(c.Cid, o.Odt, o.pmode, ep.ProdQty, ep.Prodprice);

            Console.ReadLine();


        }

        private static void simpleExample()
        {
            EP p = new EP();
            Console.WriteLine("enter");
            p.Prodid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("name");
            p.Prodname = Console.ReadLine();

            Console.WriteLine("measure");
            p.UoM = Console.ReadLine();

            Console.WriteLine("price");
            p.Prodprice = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("quantity");
            p.ProdQty = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("watt");
            p.Watt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("date");
            p.MD = Convert.ToDateTime(Console.ReadLine());

            decimal amt = p.calctotal();
            Console.WriteLine($"total amt = {p.ProdQty} at price of {p.Prodprice} = {amt}");

            Console.WriteLine("******************");
            decimal ordervalue = p.calcdisc();
            Console.WriteLine($"after discount{ordervalue}");

            Console.ReadLine();

        }

        private static void Calci()
        {
            Maths m = new Maths();
            Console.WriteLine("enetr value:");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value:");
            int no2 = Convert.ToInt32(Console.ReadLine());

            int addres = m.Addition(no1, no2);//Actual parameters
            Console.WriteLine(addres);

            int subres = m.sub(no1, no2);
            Console.WriteLine(subres);
        }
    }
}
