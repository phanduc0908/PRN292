using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class DuplicateException:ApplicationException
    {
        public string name { get; set; }
        public DuplicateException(string message, string name) :base(message)
        {
            this.name = name;
        }
    }
}
