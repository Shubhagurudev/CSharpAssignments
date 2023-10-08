using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TemperatureConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "enter temperature in celsius degree");
            int celsius = Convert.ToInt32(Console.ReadLine());

            int kelvin = Convert.ToInt32(celsius + 273.15);
            int Farenheit =Convert.ToInt32( (celsius * 1.8) + 32);

            Console.WriteLine(  $" kelvin = {kelvin}");
            Console.WriteLine(  $" Farenheit = {Farenheit}");

            Console.ReadLine();

        }
    }
}
