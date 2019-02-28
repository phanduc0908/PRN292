using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_DATA
{
    public class DataSupplier
    {
        public static DataTable GetAllSuppliers()
        {
            string sql = "select * from Suppliers";
            return DataAccess.GetDataBySql(sql);
        }
    }
}
