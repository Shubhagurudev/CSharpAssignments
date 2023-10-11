using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOPSandArrays
{
    internal class PS1SumOfArrayOfElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter no of elements:");
            int num = Convert.ToInt32( Console.ReadLine() );

            int[] arr = new int[num];
            int sum = 0;

            Console.WriteLine(" Enter the elements:");
            for( int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32( Console.ReadLine() ) ;
                sum = sum + arr[i]; 
            }

            Console.WriteLine($" The sum of array of elements is {sum}");
            Console.ReadLine();
        }
    }
}
