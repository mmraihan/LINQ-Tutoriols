namespace Left_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){Id=1, Name="A-1", AddressId=1},
                new Student(){Id=2, Name="A-11", AddressId=0},
                new Student(){Id=3, Name="A-12", AddressId=2},
                new Student(){Id=4, Name="A-13", AddressId=2},
                new Student(){Id=5, Name="A-14", AddressId=3}
            };

            var addresses = new List<Address>()
            {
                new Address(){Id=1, AddressLine="Line-1" },
                new Address(){Id=2, AddressLine="Line-2" },
                new Address(){Id=3, AddressLine="Line-3" },
                new Address(){Id=4, AddressLine="Line-4" },
                new Address(){Id=5, AddressLine="Line-5" }
            };

            var qs = (from s in students
                      join a in addresses on s.AddressId equals a.Id into sa
                      from studentAddress in sa.DefaultIfEmpty()

                      select new
                      {
                          StudentName =s.Name,
                          StudentAddress = studentAddress != null ? studentAddress.AddressLine :"Na"
                      }).ToList();


            foreach (var item in qs)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }         
    }

    class Address
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }
    }


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }

    }
}
