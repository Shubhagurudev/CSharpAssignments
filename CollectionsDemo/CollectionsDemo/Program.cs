using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 9,4,6,7,2,100,500,75,56,65 };

            foreach (var item in a)
            {
                Console.WriteLine( item );
            }
            Console.WriteLine(  "***********");
            Array.Sort(a);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(  "************");
            //Array.Reverse(a);
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(  "************");

            Array.Resize(ref a, 11);
            a[10] = 7000;
            foreach(var item in a)
            {
                Console.WriteLine(item);
            }

            Array.Resize(ref a, 9);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }



































            //Array.Clear(a, 7, 4);
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}










            Console.ReadLine(); 


        }
    }
}
