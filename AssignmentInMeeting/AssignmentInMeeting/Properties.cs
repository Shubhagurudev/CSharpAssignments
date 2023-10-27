using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInMeeting
{
    internal class Properties
    {
        public int Maths { get; set; }
        public int Science { get; set; }
        public int English { get; set; }

        public int Calculate()
        {
            int totalMarks = Maths + Science + English;
            return totalMarks;
        }
    }
}
