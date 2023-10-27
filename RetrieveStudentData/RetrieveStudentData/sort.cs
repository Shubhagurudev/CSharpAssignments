﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveStudentData
{
    internal class sort
    {
        // C# program to demonstrate the use of 
// List<T>.Sort(Int32, Int32, IComparer<T>) 
// Method 
//using System; 
//using System.Collections.Generic; 

class GFG : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            // "CompareTo()" method 
            return x.CompareTo(y);

        }
    }

    public class geek
    {
        public static void Main()
        {
            List<string> list1 = new List<string>();

            // list elements 
            list1.Add("C++");
            list1.Add("Java");
            list1.Add("C");
            list1.Add("Python");
            list1.Add("HTML");
            list1.Add("CSS");
            list1.Add("Scala");
            list1.Add("Ruby");
            list1.Add("Perl");

            int range = 4;
            Console.WriteLine("Original List");

            // Display Original List 
            Display(list1);

            // "gg" is the object 
            GFG gg = new GFG();

            Console.WriteLine("\nSort a range with comparer:");

            // sort the list within a 
            // range of index 1 to 4 
            // where range = 4 
            list1.Sort(1, range, gg);

            // Display sorted List 
            Display(list1);

            Console.WriteLine("\nBinarySearch and Insert Dart");

            // Binary Search and storing 
            // index value to "index" 
            int index = list1.BinarySearch(0, range,
                                        "Dart", gg);

            if (index < 0)
            {
                list1.Insert(~index, "Dart");
                range++;
            }

            // Display the List 
            // after inserting "Dart" 
            Display(list1);

        }

        // Display function 
        public static void Display(List<string> list)
        {
            foreach (string g in list)
            {
                Console.WriteLine(g);
            }
        }
            
    }


    }
}
