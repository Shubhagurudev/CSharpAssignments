using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MiniCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int addition = n1 + n2;
            int subtraction = n1 - n2;
            int multiplication = n1 * n2;
            int division = n1 / n2;
            int modulus = n1 % n2;

            Console.WriteLine($"{n1} + {n2}  = {addition}");
            Console.WriteLine($"{n1} - {n2}  = {subtraction}");
            Console.WriteLine($"{n1} * {n2}  = {multiplication}");
            Console.WriteLine($"{n1} / {n2}  = {division}");
            Console.WriteLine($"{n1} mod {n2}  = {modulus}");
            Console.ReadLine();
        }
    }
}
