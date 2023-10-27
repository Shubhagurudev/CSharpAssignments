using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveStudentData
{
    public class check
    {
        static void Main(string[] args)
        {





            start:
            string[] words = File.ReadAllText("C:\\Users\\shubh\\source\\repos\\StudentDataTextFile.txt").Split(' ');

            Console.WriteLine("word to search");
            string wordtobesearch = Console.ReadLine();
            bool condition  = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(wordtobesearch) == true)
                {
                    condition = true;
                    break;

                }
                else
                {
                    condition = false;
                }
            }
            if (condition == true)
            {
                Console.WriteLine(  "{0} found ",wordtobesearch);

            }
            else
            {
                Console.WriteLine(  "{0} not found",wordtobesearch);
            }
            goto start;



            Console.ReadLine();


        }
    }
}
