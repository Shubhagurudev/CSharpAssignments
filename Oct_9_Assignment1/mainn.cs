using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Oct_9_Assignment1
{
    public class mainn
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            

            Employee e = new Employee();
            e.Eid = 1;
            e.Ename = "smruthi";
            e.Salary = 10000.22f;
            Console.WriteLine("\n id=" + e.Eid);
            Console.WriteLine("\n name = " + e.Ename);
            Console.WriteLine("\n salary = " + e.Salary);
            Console.WriteLine(  "\n Salary after special allowance");
            double sal = e.CalcSalary(e.Salary);
            //Console.WriteLine(sal);



            Propertiess p = new Propertiess();
            p.Maths = 100;
            Console.WriteLine(  " \n");
            Console.WriteLine(" Maths marks");
            Console.WriteLine(p.Maths);
            p.Science = 99;
            Console.WriteLine(" \n");
            Console.WriteLine(" Science");
            Console.WriteLine(p.Science);
            p.English = 98;
            Console.WriteLine(" \n");
            Console.WriteLine(" English");
            Console.WriteLine(p.English);

            int totalmarks = p.Calculate(p.Maths, p.Science, p.English);
            Console.WriteLine("total marks = " + totalmarks);

            Console.ReadLine();
        }
    }
}
