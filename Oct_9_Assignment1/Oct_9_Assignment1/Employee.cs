using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct_9_Assignment1
{
    public class Employee:Student
    {
		public int eid;

		public int Eid
		{
			get { return eid; }
			set { eid = value; }
		}

		public string ename;
		public string Ename
		{
			get { return ename; }
			set { ename = value; }
		}

		private float salary;

		public float Salary
		{
			get { return salary; }
			set { salary = value; }
		}

		public double CalcSalary(float salary)
		{
			float s = salary;
			
			if(s>10000.00 && s <20000.00)
			{
				 double res = s + 0.05 + 0.1;
                Console.WriteLine($"{res}");
            }
			else if(s >20000.00 && s<30000.00)
			{
				 double res = s + 0.12 + 0.07 + 0.12;
                Console.WriteLine($"{res}");
            }
			return 0;
		
            
        }



	}
}
