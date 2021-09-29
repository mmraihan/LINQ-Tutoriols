using System;
using System.Collections.Generic;
using System.Linq;

namespace Where_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Multiple Condition

            var dataSourse = new List<int>() { 50,51,54,100,101,102,103,104};

            var querySyntax = (from number in dataSourse
                               where number > 50 && number <100
                               select number).ToList();

            var methodSyntax = dataSourse.Where(x => x > 50 && x < 100);

           var methoSyntax = dataSourse.Where(num => num <= 5 || num > 9).ToList();



            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item + ",");
            }
           Console.ReadKey();


            Console.WriteLine();
            foreach (var item in methodSyntax)
            {
                Console.Write(item + ",");
            }


            #endregion


            #region Complex Data

            var dataSource2 = new List<Employee>()
            {
                new Employee(){Id=1, Name="Raihan", Programming=new List<Techs>
                {
                    new Techs(){Technology="C#"},
                    new Techs(){Technology="C#-2"},
                    new Techs(){Technology="C#-3"},
                } },

                new Employee(){Id=2, Name="Raihan2", Programming=new List<Techs>
                {
                    new Techs(){Technology="TypeScript"},
                    new Techs(){Technology="TypeScript-2"},
                    new Techs(){Technology="TypeScript-3"},
                } },

                   new Employee(){Id=3, Name="Raihan3", Programming=new List<Techs>
                {
                    new Techs(){Technology="JS"},
                    new Techs(){Technology="JS-2"},
                    new Techs(){Technology="JS-3"},
                } },

                         
        };
            var querySyntax2 = (from empployee in dataSource2
                                where empployee.Programming.Count ==2
                                select empployee).ToList();

            foreach (var item in querySyntax2)
            {
                Console.WriteLine(item.Name);
            }


            #endregion
        }
    }
}
