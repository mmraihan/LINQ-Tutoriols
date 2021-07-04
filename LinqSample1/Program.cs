using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////   1. Query syntex  ///////////////////////////
            
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7,8,9,10 }; //Data source

            var querySyntax = from obj in list  // Query
                             where obj > 2
                             select obj;

            foreach (var item in querySyntax) // Execution
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------------");




            ////////////////////////// 2. Method Syntex  //////////////////////////

            var methodSyntax = list.Where(obj => obj > 2); // Query
            foreach (var item in methodSyntax) // Execution
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------------");


            ////////////////////////// 3. Mix Syntex  //////////////////////////





        }
    }
}
