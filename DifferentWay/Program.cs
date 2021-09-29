using System;
using System.Collections.Generic;
using System.Linq;

namespace DifferentWay
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };  //Data Source

            #region Query Syntax
            var querySyntax = from obj in list  //Initialize
                              where obj > 2 // Condition
                              select obj; // Slection


            foreach (var item in querySyntax) //Execution
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Method Syntax

            var methodSyntax = list.Where(obj => obj > 3);

            Console.WriteLine("--------Method Syntax--------------\n");
            foreach (var item in methodSyntax)
            {
                Console.Write(item +",");
            }

            #endregion


     
            Console.ReadKey();
        }
    }
}
