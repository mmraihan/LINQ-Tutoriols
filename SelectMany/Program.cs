using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Muba", "Raihan" };

            var dataSource = new List<Employee>()
            {
                new Employee(){Id=1, Name="Muba", Programming=new List<string>(){"C#", "JS","TypeScrip"}},
                new Employee(){Id=2, Name="Muba2", Programming=new List<string>(){"C#-2", "JS-2","TypeScrip-2"}},
                new Employee(){Id=3, Name="Muba3", Programming=new List<string>(){"C#-3", "JS-3","TypeScrip-3"}}
            };

            #region Method Syntax
            var methodResult = names.SelectMany(x => x).ToList();


            #endregion

            #region Query Syntax

            var queryResult = (from rec in names
                              from c in rec
                              select c).ToList();


            #endregion

            #region Method Syntax

            var methodSyntax2 = dataSource.SelectMany(emp => emp.Programming).ToList();

            foreach (var item in methodSyntax2)
            {
                Console.WriteLine("Progaramming language: "+item);
            }

            #endregion

            #region Query Syntax

            var QuerySyntax2 = (from emp in dataSource
                                from skill in emp.Programming

                                select skill).ToList();


            foreach (var item in QuerySyntax2)
            {
                Console.WriteLine("Progaramming language by QSyntax: " + item);
            }

            #endregion

        }
    }
}
