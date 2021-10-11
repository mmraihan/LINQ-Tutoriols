using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantifier_AllOperator
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public List<Subject> Subjects { get; set; }

    }

    public class Subject
    {
        public string SubName { get; set; }
        public int SunMarks { get; set; }
    }
}
