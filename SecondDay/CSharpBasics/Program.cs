using System;


namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helloooooo");
           // int num = Console.ReadLine();//it will receive input and store it in the string format.So need to convert it into int from string
          /*** Console.WriteLine("enter 1st num");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd num");
            int numm = Convert.ToInt32(Console.ReadLine());
            int result = num + numm;
            Console.WriteLine($"{num} + {numm} = {result}");

            Console.WriteLine("enter 1st num");
            float numf = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter 2nd num");
            float nummf = Convert.ToSingle(Console.ReadLine());
            float resulte = numf + nummf;
            Console.WriteLine($"{numf} + {nummf} = {resulte}");

            Console.WriteLine("enter 1st num");
            double numd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter 2nd num");
            double nummd = Convert.ToDouble(Console.ReadLine());
            double resulti = numd + nummd;
            Console.WriteLine($"{numd} + {nummd} = {resulti}");***/
            Console.WriteLine($"Todays date = {DateTime.Now}");
            DateTime joindate = new DateTime(2023, 10, 03);
            Console.WriteLine(joindate);
            Console.WriteLine("enter true or false");
            bool IsEmployee = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(IsEmployee);
            Console.WriteLine("char");
            char c =Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c);
            DateTime birth =Convert.ToDateTime(Console.ReadLine()); 
            Console.WriteLine(birth);
            Console.WriteLine(birth.Year);
            Console.WriteLine(birth.Month);
            Console.ReadLine();

        }
    }
}
