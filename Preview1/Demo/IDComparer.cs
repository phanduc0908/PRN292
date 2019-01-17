using System.Collections.Generic;

namespace Demo
{
    public class IDComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.id - y.id;
        }
    }
    public class NameComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.name.CompareTo(y.name);
        }
    }
}
