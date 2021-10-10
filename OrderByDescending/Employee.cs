using System;
using System.Collections.Generic;
using System.Text;

namespace OrderByDescending
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Tecs> Programming { get; set; }

    }

    public class Tecs
    {
        public string Technology { get; set; }

    }


}
