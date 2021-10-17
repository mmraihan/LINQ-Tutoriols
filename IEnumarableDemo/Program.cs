using System;
using System.Collections.Generic;

namespace IEnumarableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student() { Id = 1, Name = "Raihan", Standard = 12 };
            Student std2 = new Student() { Id = 2, Name = "Raihan2", Standard = 11 };
            Student std3 = new Student() { Id = 3, Name = "Raihan3", Standard = 10 };

            #region With List
           // List<Student> students = new List<Student>() { std1, std2, std3 };
            #endregion

            #region Without List

            School students = new School();
            students.AddMethod(std1);
            students.AddMethod(std2);
            students.AddMethod(std3);


            #endregion

            foreach (Student item in students)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name} Standard: {item.Standard}");
            }

            Console.ReadKey();
        }
    }
}
