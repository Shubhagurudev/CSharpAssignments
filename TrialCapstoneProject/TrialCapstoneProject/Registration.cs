using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialCapstoneProject
{
    public class Registration
    {
        public int JobSeekerRegistration()
        {        
        public string EmailId { get; set; }
        public string Password { get; set; }
        public long PhoneNo { get; set; }
        public int GraduatedYear { get; set; }

        }

        public int Employer()
        {
        Console.WriteLine("enter name");
        string ename = Console.ReadLine(); Console.WriteLine("enter email");
        string eemailId = Console.ReadLine();
        Console.WriteLine("enter password");
        string epassword = Console.ReadLine();
        Console.WriteLine("employee registered succcessfully");

         }

        List<string> Skills = new List<string>();
        for(int i=0;i<10;i++)
         {
        string skill = Console.ReadLine();
        }

        foreach(var skills in skill)
        {
        Console.WriteLine(skills);
        }
    }
}


