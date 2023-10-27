using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SreeFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=10, j=0, k;
            try
            {
                k = i / j;
                Console.WriteLine($"{k}");

            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message);
                Console.WriteLine(  ex.StackTrace);
                Console.WriteLine(  ex.Source);
            }
            Console.ReadLine();
        }
    }
}
