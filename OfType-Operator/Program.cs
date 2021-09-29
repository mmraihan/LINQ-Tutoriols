using System;
using System.Collections.Generic;
using System.Linq;

namespace OfType_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<object>() { "Muba", "Raihan", "Mridul", "Zakaria", 1, 2, 3, 4, 5 };

            var methodSyntax = dataSource.OfType<string>().Where(x=>x.Length>3).ToList();
            //////////////////////(With Condition)////////////////////////
            //var methodSyntax = dataSource.OfType<string>().Where(x => x.Length > 3).ToList(); 


            var querySyntax = (from x in dataSource
                               where x is string
                               select x).ToList();


            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
