using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Employee
    {
        int id { get; set; }
        string name { get; set; }

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return "ID:" + id + "- Name:" + name;
        }
        public void Display()
        {
            Console.WriteLine("ID:" + id + "- Name:" + name);
        }
        // Khai báo virtual để có thể override ở class kế thừa nó
        public virtual void ShowInfo()
        {
            Console.WriteLine("ID:" + id + "- Name:" + name);
        }
    }
    class Fulltime : Employee
    {
        public int salary { get; set; }
        public Fulltime(int id, string name, int salary) : base(id, name)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + " -Salary:" + salary;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine(salary);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
