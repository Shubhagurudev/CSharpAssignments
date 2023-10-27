using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Mainn
    {
        static void Main(string[] args)
        {

            Laptop hp = new Laptop();
            hp.RAM = 16;
            hp.HardDisk = 915;
            hp.Processor = "intel 10";
            Console.WriteLine(hp.RAM);
            Console.WriteLine(hp.HardDisk);
            Console.WriteLine(hp.Processor);
            Console.WriteLine("***************************");

            Laptop dell = new Laptop();
            dell.RAM = 32;
            dell.HardDisk = 1000;
            dell.Processor = "intel 5";
            Console.WriteLine(dell.RAM);
            Console.WriteLine(dell.HardDisk);
            Console.WriteLine(dell.Processor);
            Console.WriteLine("*****************************");
            Console.ReadLine(); 
        }
    }
}
