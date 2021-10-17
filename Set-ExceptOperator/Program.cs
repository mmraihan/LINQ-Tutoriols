using System;
using System.Collections.Generic;
using System.Linq;

namespace Set_ExceptOperator
{
    class Program
    {
        static void Main(string[] args)
        {
        #region Notes
        //Except: return all data from 1 data source that don’t exist in second data source.
            #endregion


            #region Value Type
        //List<string> dataSOurce1 = new List<string>() { "A", "B", "C", "D" };
        //List<string> dataSOurce2 = new List<string>() { "E", "F", "C", "D" };

        //var ms = dataSOurce1.Except(dataSOurce2).ToList();
            #endregion


        List<Student> students = new List<Student>()
            {
                new Student(){Id=1, Name="RAihan"},
                new Student(){Id=2, Name="RAihan2"},
                new Student(){Id=3, Name="RAihan3"},
                new Student(){Id=4, Name="RAihan4"}
            };

            List<Student> students2 = new List<Student>()
            {
                new Student(){Id=1, Name="RAihan"},
                new Student(){Id=2, Name="RAihan2"},
                new Student(){Id=5, Name="RAihan3"},
                new Student(){Id=6, Name="RAihan4"}
            };


            //var ms2 = students.Select(x => x.Id).Except(students2.Select(x => x.Id)).ToList();
            var ms2 = students.Except(students2).ToList();

            foreach (var item in ms2)
            {
                Console.WriteLine(item.Id);
            }


            Console.ReadKey();
        }
    }
}
