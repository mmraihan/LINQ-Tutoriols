using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1, Name= "Raihan", Email="admin@exaple.com"},
                new Employee(){Id=2, Name= "Raihan2", Email="admin@exaple.com"},
                new Employee(){Id=3, Name= "Raihan3", Email="admin@exaple.com"},
                new Employee(){Id=4, Name= "Raihan4", Email="admin@exaple.com"},
                new Employee(){Id=5, Name= "Raihan5", Email="admin@exaple.com"}
            };

            //var selectQuery = (from emp in employees
            //                  select new Student()
            //                  {
            //                      StudentId=emp.Id,
            //                      StEmail=emp.Email,
            //                      FullName=emp.Name
                                  

            //                  }).ToList();


            var selectMethod = employees.Select(emp => new Student()
            {
                StudentId = emp.Id,
                StEmail = emp.Email,
                FullName = emp.Name
            }).ToList();

            foreach (var item 
                in selectMethod)
            {
                Console.WriteLine($"Id={item.StudentId}, Email={item.StudentId}, Fullname={item.FullName}");

            }



        }
    }
}
