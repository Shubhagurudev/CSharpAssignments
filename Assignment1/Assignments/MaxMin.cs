using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MaxMin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine($" {FirstNumber} is maximum");
                Console.WriteLine($" {SecondNumber} is minimum");
            }
            else
            {
                Console.WriteLine($" {FirstNumber} is minimum");
                Console.WriteLine($" {SecondNumber} is maximum");
            }
           

            Console.ReadLine();
        }
       
    }
}
