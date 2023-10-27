using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Searching
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 9, 4, 6, 7, 2, 100, 500, 75, 56, 65 };

            Array.Sort(a);//if u dont sort then gives negative value
            foreach(var item in a)
            {
                Console.WriteLine(  item);
            }
            int index = Array.BinarySearch(a, 9);
            Console.WriteLine(index);
            Console.ReadLine();
            Console.WriteLine(  "*******************");

            int[] newa = new int[a.Length];
            //Array.Copy(a,newa,a.Length);

            Array.Copy(a,newa,5);
            //Array.Copy(a, newa, a.Length);

            foreach (var item in newa)
            {
                Console.WriteLine(  item);
            }
            Console.ReadLine( );

        }
    }
}
