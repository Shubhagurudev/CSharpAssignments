using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class multiplicationOf3numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number:");
            int ThirdNumber = Convert.ToInt32(Console.ReadLine());

            int multiplication = FirstNumber * SecondNumber * ThirdNumber;

            Console.WriteLine( $" The result of {FirstNumber} * {SecondNumber} * {ThirdNumber} is {multiplication}");

            Console.ReadLine();

        }
    }
}
