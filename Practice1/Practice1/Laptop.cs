using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Laptop
    {
        int ram;//variable
        public int RAM { set { ram = value; } get { return ram; } }//property//once assigning and reading

        int hd;
        public int HardDisk
        {

            set
            {
                if (value > 0)
                {
                    hd = value;
                }
                else
                {
                    Console.WriteLine("not valid..........");
                }
            }
             get { return hd; }
        }

        string processor;

        public string Processor { set { processor = value; } get { return processor; } }


    }
}
