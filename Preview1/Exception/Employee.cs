using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return "ID-" + id + " - Name-" + name;
        }
    }
}
