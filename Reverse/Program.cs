using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Mridul", "Raihan", "Sabbir", "Tanjeeb", "Sultan" };



            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------------");


           var reversed= names.AsEnumerable().Reverse();
            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }
        }
    }
}
