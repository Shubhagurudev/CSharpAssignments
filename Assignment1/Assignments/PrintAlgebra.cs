using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class PrintAlgebra
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter FirstNumber");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SecondNumber");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("EnterThirdNumber");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int result1 = ((n1 + n2) * n3);
            int result2 = ((n1 * n2) + (n2 * n3));

            Console.WriteLine($"The result is ({n1} + {n2}) * {n3} = {result1}  and {n1}.{n2} + {n2}.{n3} = {result2}");
            Console.ReadLine();
        }

    }
}
