using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(2, "Phan Van Duc");
            // Console.WriteLine(employee.ToString());
            employee.Display();
            Fulltime f = new Fulltime(2, "Duc", 21111);
            // Console.WriteLine(f.ToString());
            employee.Display();



            Console.ReadLine();
        }
    }
}
