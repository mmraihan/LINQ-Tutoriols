using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumarableDemo
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }
    }

     class School : IEnumerable
    {
        List<Student> students = new List<Student>();

        public void AddMethod(Student s)
        {
            students.Add(s);
        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }
}
