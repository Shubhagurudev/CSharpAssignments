using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Employee
    {
        //Constructor --> method with same name as that of class without any return type.
        public Employee()
        {

        }
        //parameter constructor
       public int empid;//variables
        public string ename;
        public string eloc;
        public Employee(int iid, string iname)//parameters)
        {
            empid = iid;
            ename = iname;

        }
        public Employee(int iid, string iname, string iloc)
        {
            empid = iid;
            ename = iname;
            eloc = iloc;
        }
        
    }
}
