using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SjcitLibrary
{
    public class Order:Discount
    {
        public enum PaymentMode
        {
            cash,
            upi,
            debit,
            credit,
            netbanking
        }
        public  int oid;

        public int Oid
        {
            get { return oid; }
            set { oid = value; }
        }

        public DateTime odt;

        public DateTime Odt
        {
            get { return odt; }
            set { odt = value; }
        }

        public PaymentMode pm;

        public PaymentMode Pmode
        {
            get { return pm; }
            set { pm = value; }
        }

        

        public void OrderDetails(int oid, DateTime odt, PaymentMode pm,int pid, string pname ,float qty,decimal price)
        {
            float Q = qty;
            decimal P = price;
            int prodid = pid;
            string prodname = pname;
            
            decimal TotalAmt = base.CalculateTotal(qty, price);

           decimal Discountafter = base.CalculateDiscount(qty,price);
            Console.WriteLine(  "\n \n ");
            Console.WriteLine(  "******************************");

            Console.WriteLine(  "Order booked successfully!!!");
            Console.WriteLine($"Order details: \n  Order id = {Oid} \n Order date = {Odt} \n Payment mode = {Pmode} \n Product id = {prodid} \n Product name = {prodname} \n  Quantity = {Q} \n  Price = {P} \n  Total Amount = {TotalAmt} \n After discount total = {Discountafter}");
        }
    }
}
