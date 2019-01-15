using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class DuplicateException:ApplicationException
    {
        public DuplicateException(string message):base(message){}
    }
    class PositiveException : ApplicationException
    {
        public double basePrice { get; set; }
        public PositiveException(string message, double basePrice) :base(message)
        {
            this.basePrice = basePrice;
        }
    }
}
