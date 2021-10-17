using System;
using System.Collections.Generic;
using System.Linq;

namespace Set_DistinctOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 3, 12, 12, 11, 11, 12, 1, 3, 5 };

            //var ms = numbers.Distinct().ToList();

            //var qs = (from num in numbers
            //          select num).Distinct();



            List<Student> students = new List<Student>()
            {
                new Student(){Id=1,Name="Raihan"},
                new Student(){Id=2,Name="Raihan2"},
                new Student(){Id=3,Name="Raihan3"},
                new Student(){Id=3,Name="Raihan3"},
            };

            var ms = students.Select(x => x.Name).Distinct().ToList();

            foreach (var item in ms)
            {
                Console.WriteLine(item);
            }
        }
    }
}
