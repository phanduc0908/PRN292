using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_DATA
{
    public class DataOrder
    {
        public static DataTable GetAllOrders()
        {
            string sql = "select * from Orders";
            return DataAccess.GetDataBySql(sql);
        }
    }
}
