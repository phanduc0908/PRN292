using LAB1.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1.GUI
{
    class BasePriceComparer : IComparer<Auto>
    {
        public int Compare(Auto x, Auto y)
        {
            return x.basePrice.CompareTo(y.basePrice);
        }
    }

    class IdComparer : IComparer<Auto>
    {
        public int Compare(Auto x, Auto y)
        {
            return x.id.CompareTo(y.id);
        }
    }
}
