using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class ConstructorDemo
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee();
                e1.empid = 101;
                e1.ename = "jass";
                e1.eloc = "london";
            
            //Employee e2 = new Employee(102, "john", "blore");
             Console.WriteLine( e1.ename);
             Console.ReadLine();

        }
    }
}
