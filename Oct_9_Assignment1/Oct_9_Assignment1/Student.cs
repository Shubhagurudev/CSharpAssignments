using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct_9_Assignment1
{
    public class Student

    {
            public Student()
            {
            }

            int sid;
            string sname;
            int age;

            public Student(int Studid, string Studname)
            {
                sid = Studid;
                sname = Studname;
            }

            public Student(int Studid, string Studname, int Age)
            {
                sid = Studid;
                sname = Studname;
                age = Age;
            }
        
    }
}

