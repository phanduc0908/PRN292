using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1.GUI
{
    class ExistingItemException:SystemException
    {
        public ExistingItemException(string Info) : base("Employee /" + Info + "/ already has been existed")
        {
        }
    }
}
