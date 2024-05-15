using System;
using System.Collections.Generic;
using System.Linq;

namespace Group_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Alice", CategoryId = 1 },
                new Student { Id = 2, Name = "Alice-2", CategoryId = 1 },
                new Student { Id = 3, Name = "Bob", CategoryId = 2 },
                new Student { Id = 4, Name = "Bob-2", CategoryId = 2 },
                new Student { Id = 5, Name = "Charlie", CategoryId = 3 }
            };



            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Science" },
                new Category { Id = 2, Name = "Arts" },
                new Category { Id = 3, Name = "Sports" },
                new Category { Id = 4, Name = "Sports-2" },
                new Category { Id = 5, Name = "Sports-3" }
            };

            var qs = from c in categories
                     join std in students on c.Id equals std.CategoryId into stdGroups
                     select new { c, stdGroups };


            foreach (var item in qs)
            {
                Console.WriteLine(item.c.Name + "-------");
                foreach (var c in item.stdGroups)
                {
                    Console.WriteLine(c.Name);
                }
            }

            Console.ReadLine();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }

    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
