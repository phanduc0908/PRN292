using Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpList = new Employee[3];
            EmpList[0] = new Employee(1, "Phan Duc");
            EmpList[1] = new Employee(3, "Phan Khoa");
            EmpList[2] = new Employee(2, "Phan Linh");
            for(int i =0; i< 3; i++)
            {
                Console.WriteLine(EmpList[i].ToString());
            }

            Array.Sort(EmpList);
            Console.WriteLine("----Sort by ID----");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(EmpList[i].ToString());
            }

            Array.Sort(EmpList, new NameComparer());
            Console.WriteLine("----Sort by Name----");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(EmpList[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
