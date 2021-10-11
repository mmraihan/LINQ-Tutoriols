using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantifier_AnyOperator
{
    class Program
    {
        //Any operator is used to check whether at least one element of a data source satisfy a sepecified condition.
        //Checks if any of the elements in a sequence satisfies the specified condition
        static void Main(string[] args)
        {
            var datasource = new List<Student>()
            {
                new Student(){Name="raihan", Marks=90,Subjects= new List<Subject>()
                {
                 new Subject(){SubName="C#", SunMarks=75},
                 new Subject(){SubName="C#2", SunMarks=85},
                 new Subject(){SubName="C#3", SunMarks=80},
                 new Subject(){SubName="C#4", SunMarks=75},
                }
                },

                new Student(){Name="Mridul", Marks=85,Subjects= new List<Subject>()
                {
                 new Subject(){SubName="C#", SunMarks=89},
                 new Subject(){SubName="C#2", SunMarks=85},
                 new Subject(){SubName="C#3", SunMarks=90},
                 new Subject(){SubName="C#4", SunMarks=95},
                }
                },

                new Student(){Name="Taneeb", Marks=75,Subjects= new List<Subject>()
                {
                 new Subject(){SubName="C#", SunMarks=75},
                 new Subject(){SubName="C#2", SunMarks=85},
                 new Subject(){SubName="C#3", SunMarks=80},
                 new Subject(){SubName="C#4", SunMarks=65},
                }
                }

            };

            var methodSyntax = datasource.Where(std => std.Subjects.Any(x => x.SunMarks > 84)).Select(s => s.Name).ToList();


            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
        }
    }
}
