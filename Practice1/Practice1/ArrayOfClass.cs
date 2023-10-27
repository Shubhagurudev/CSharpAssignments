using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class ArrayOfClass
    {
        static void Main(string[] args)
        {
            Laptop[] laptop = new Laptop[2];// array object
            laptop[0] = new Laptop(); // first laptop object
            laptop[0].RAM = 16;
            laptop[0].HardDisk = 512;

            laptop[1] = new Laptop();
            laptop[1].RAM = 8;
            laptop[1].HardDisk = 912; ;

            foreach(var item in laptop)
            {
                Console.WriteLine(  item.RAM);
                Console.WriteLine( item.HardDisk);
                Console.ReadLine(); 
            }
        }
    }
}
