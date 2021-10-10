using System;
using System.Collections.Generic;
using System.Linq;

namespace ThenByAndThenByDescending
{
    class Program
    {
        //The ThenBy and ThenByDescending extension methods are used for sorting on multiple fields.
        static void Main(string[] args)
        {
            var dataSource = new List<Employee>()
            {
                new Employee(){Id=3, FirstName="Foo", LastName="Smith", Email= "example@live.com"},
                new Employee(){Id=2,FirstName="Mark", LastName="Thomas",Email= "example2@live.com"},
                new Employee(){Id=1, FirstName="Mark", LastName="Allen", Email= "example3@live.com"},
               new Employee(){Id=4, FirstName="Foo", LastName="Andersom", Email= "example3@live.com"},
            };



            var ms = dataSource.OrderBy(emp => emp.FirstName).ThenBy(emp=>emp.LastName).ToList();

            var qs = (from emp in dataSource

                      orderby emp.FirstName descending, emp.LastName descending
                      select emp).ToList();

            foreach (var item in ms)
            {
                Console.WriteLine($"Id {item.Id}, FirstName: {item.FirstName}, LastName: {item.LastName}");
            }
            Console.WriteLine("------------------------");

            foreach (var item in qs)
            {
                Console.WriteLine($"Id {item.Id}, FirstName: {item.FirstName}, LastName: {item.LastName}");
            }

        }
    }
}
