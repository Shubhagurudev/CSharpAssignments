using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class GetYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter days:");
            int days = Convert.ToInt32(Console.ReadLine());

            float  year = days / 365;
            double months = days / 30.42;
            float weeks = days / 7;
            Console.WriteLine($" no of years = {year}");
            Console.WriteLine($"no of months = {months}");
            Console.WriteLine($" no of days = {weeks}");
            Console.ReadLine();
        }
    }
}
