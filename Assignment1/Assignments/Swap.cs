using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Swapping  :     n1 = {FirstNumber}      n2 = {SecondNumber} ");
            Console.WriteLine("     ");

            int temp;
            temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = temp;

            Console.WriteLine($"After Swapping :     n1 = {FirstNumber}     n2 = {SecondNumber}");
            Console.ReadLine();
        }
    }
}
