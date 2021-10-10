using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Premetive Data Source
            var datasource = new List<int> { 22, 45, 11, 90, 2, 4, 2, 1, 98, 333, 43 };

            var dataSource2 = new List<string>
            {
                "Mub", "Raihan", "Mridul", "Tanjeeb"
            };
            #endregion


            #region Int
            var methodSyntax = datasource.OrderByDescending(num => num);

            var querySyntax = (from num in datasource
                               orderby num descending
                               select num).ToList();

            foreach (var item in methodSyntax)
            {
                //Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------");
            foreach (var item in querySyntax)
            {
                //Console.WriteLine(item);
            }
            #endregion

            #region String


            var ms = dataSource2.OrderByDescending(name => name).ToList();

            var qs = (from name in dataSource2
                      orderby name descending
                      select name).ToList();

            foreach (var item in qs)
            {
                //Console.WriteLine(item);
            }

            #endregion



            #region NonPremetive Data Source

            var dataSource3 = new List<Employee>()
            {
                new Employee(){Id=1,Name="Mridul", Email= "example@live.com"},
                new Employee(){Id=2,Name="Mridul2", Email= "example2@live.com"},
                new Employee(){Id=3,Name="Mridul3", Email= "example3@live.com"},
            };



            var methodSyntax2 = dataSource3.OrderByDescending(e => e.Id).ToList();


            foreach (var item in methodSyntax2)
            {
                Console.WriteLine($"Id {item.Id}, Name: {item.Name}");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
