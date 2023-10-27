using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjcitLibrary
{
    public class Discount : Products
    {
        public decimal CalculateDiscount(float qty, decimal price)
        {
            decimal Afterdiscount = 0;
            float Qu = qty;
            decimal Pr = price;
            decimal res = Convert.ToDecimal(Qu) * Pr;

            if (res > 1 && res < 100)
            {
                decimal discount = (res * 2) / 100;
                Console.WriteLine($"Before discount = {res}");
                Console.WriteLine($"The discount given is = {discount}");
                Afterdiscount = res - discount;
                Console.WriteLine($"After discount = {Afterdiscount} ");
            }
            else if (res > 500 && res < 1000)
            {
                decimal discount = (res * 5) / 100;
                Console.WriteLine($"Before discount = {res}");
                Console.WriteLine($"The discount given is = {discount}");
                Afterdiscount = res - discount;
                Console.WriteLine($"After discount  = {Afterdiscount}");
            }
            else
            {
                Afterdiscount = res;
            }
            return Afterdiscount;
        }

    }
}



