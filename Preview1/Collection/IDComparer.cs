using Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class IDComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.id.CompareTo(y.id);
        }
    }
    public class BasePriceComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.basePrice.CompareTo(y.basePrice);
        }
    }
    public class GetPriceComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.getPrice().CompareTo(y.getPrice());
        }
    }
}
