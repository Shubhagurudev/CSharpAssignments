using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P
{
    public class SortStringsFromFile
    {
        public static void Main()
        {
            // Input number of strings to be inserted in file
            Console.Write("Enter the number of strings: ");
            int n = Convert.ToInt32(Console.ReadLine());

            try
            {
                // Open file for writing
                StreamWriter writer = new StreamWriter("file.txt");

                // Insert the strings into file
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter the string: ");
                    string name = Console.ReadLine();

                    // Writing into the file
                    writer.WriteLine(name);
                }

                // Close the writer
                writer.Close();

                // Open file for reading
                StreamReader reader = new StreamReader("C:\\Users\\shubh\\source\\repos\\StudentDataTextFile");

                // Read the lines until end of file is reached
                List<string> names = new List<string>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    names.Add(line);
                }

                // Close the reader
                reader.Close();

                // Sort the strings
                names.Sort();

                // Open the file for writing
                writer = new StreamWriter("C:\\Users\\shubh\\source\\repos\\StudentDataTextFile");

                // Insert the sorted strings into the file
                foreach (string name in names)
                {
                    writer.WriteLine(name);
                }

                // Close the writer
                writer.Close();

                // Print the sorted names
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
