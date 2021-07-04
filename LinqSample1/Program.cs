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


            /////////////////////////////1. Basic Query/////////////////////////
            var basicQuery = (from emp in employees
                             select emp).ToList();

            foreach (var item in basicQuery)
            {
                Console.WriteLine ($"Id={item.Id}, Name={item.Name}, Email= {item.Email}" );
            }

            Console.WriteLine("---------------------------------------------------------");

            /////////////////////////////2. Basic Method/////////////////////////

            var basicMethod = employees.ToList();
            foreach (var item in basicMethod)
            {
                Console.WriteLine($"Basic Method:  Id={item.Id}, Name={item.Name}, Email= {item.Email}");

            }
            Console.WriteLine("---------------------------------------------------------");


            /////////////////////////////////////Operations///////////////////////
            ///
            var basicPropQuery = (from emp in employees
                                  select emp.Id).ToList();

            foreach (var item in basicPropQuery)
            {
                Console.WriteLine($"Id={item}");

            }

            Console.WriteLine("---------------------------------------------------------");


            var basicPropMethod = employees.Select(emp => emp.Id).ToList();

            foreach (var item in basicPropMethod)
            {
                Console.WriteLine($"Id={item}");

            }



        }
    }
}
