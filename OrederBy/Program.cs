using System;
using System.Collections.Generic;
using System.Linq;

namespace OrederBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<int>() { 3, 4, 6, 1, 2, 55, 11, 47, 2 };

            var querySyntax = (from num in dataSource
                               orderby num
                               select num);
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");
            var methodSyntax = dataSource.OrderBy(num => num).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------");
            #region Condition QuerySyntax
            var querySyntax2 = (from num in dataSource
                                where num>47
                               orderby num
                               select num);
            foreach (var item in querySyntax2)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region Condition MethodSyntax
            var methodSyntax2 = dataSource.Where(num=>num>11).OrderBy(num => num).ToList();

            Console.WriteLine("Method Syntax Condition");
            foreach (var item in methodSyntax2)
            {
                Console.WriteLine(item);
            }
            #endregion





        }
    }
}
