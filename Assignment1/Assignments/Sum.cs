using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Sum
    {
        static void Main(String[] args)
        {
            Console.WriteLine("ENter value");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter value");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter value");

            int sum = n1 + n2;
            if (n1 == n2)
            {
                int res = 3 * sum;
                Console.WriteLine($"{res}");
            }
            else
            {
                Console.WriteLine($"The result is {sum}");
            }
            Console.ReadLine();
        }
    }
}
