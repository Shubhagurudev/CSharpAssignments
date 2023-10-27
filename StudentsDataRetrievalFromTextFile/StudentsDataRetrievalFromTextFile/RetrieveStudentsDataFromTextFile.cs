using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDataRetrievalFromTextFile
{
    internal class RetrieveStudentsDataFromTextFile
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream("C:\\Users\\shubh\\source\\repos\\StudentDataTextFile.txt", FileMode.Open, FileAccess.Read);


            string data = File.ReadAllText("C:\\Users\\shubh\\source\\repos\\StudentDataTextFile.txt");
            Console.WriteLine(data);

            Console.ReadLine();
        }
    }
}
