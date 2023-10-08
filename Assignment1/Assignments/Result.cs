using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Result
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks:");
            int Maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks:");
            int ComputerScience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks:");
            int English = Convert.ToInt32(Console.ReadLine());

            int TotalMarks = Maths + ComputerScience + English;
            Console.WriteLine($"TotalMarks = {TotalMarks}");

            float Per = Convert.ToSingle(TotalMarks) / 300 * 100;
            Console.WriteLine(  $"Percentage = {Per}");
            int per  = Convert.ToInt32(Per);

            if (per < 35)
            {
                Console.WriteLine("fail");
            }
            else if (per > 35 && per < 45)
            {
                Console.WriteLine("third class");
            }
            else if (per > 45 && per < 60)
            {
                Console.WriteLine("Second class");
            }
            else if (per >= 60)
                Console.WriteLine("first class");

            Console.ReadLine();

        }
    }
}
