using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Pattern
    {
        static void Main(String[] args)
        {
            Console.WriteLine("ENter value");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Console.Write($"{num}");
                    if (i % 2 != 0)
                        Console.Write(" ");

                }
                Console.WriteLine("   ");

            }
            Console.ReadLine();
        }
    }
}
