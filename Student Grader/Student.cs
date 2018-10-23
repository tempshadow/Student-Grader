using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grader
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public List<Assignments> assignmentlist = new List<Assignments>();
    }
}
