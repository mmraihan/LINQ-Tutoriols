using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumarableIQuerable
{
    class Program
    {


        static void Main(string[] args)
        {
            // List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
          

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="Mubasshir"},
                new Employee(){Id=2,Name="Raihan"},
            };

            #region IEnumarable
            IEnumerable<Employee> query = from emp in employees
                                          where emp.Id == 1
                                          select emp;

            foreach (var item in query)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
            }
            #endregion



            #region IQuerable
            IQueryable<Employee> query2 = employees.AsQueryable().Where(x => x.Id == 2);

            foreach (var item in query2)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
            }
            #endregion





            //          var querySyntax = from obj in list  //Initialize
            //                            where obj > 2 // Condition
            //                            select obj; // Slection
            //

        }
    }
}
