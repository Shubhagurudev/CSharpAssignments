using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class difference
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter value");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                int dif = n1 - n2;
                int result = dif * 2;
                Console.WriteLine($" difference = {dif}");
                Console.WriteLine($" result = {result}");
            }
            else
            {
                int res = n2 - n1;
                Console.WriteLine($" result = {res}");
                
            }
            Console.ReadLine();
        }
    }
}
