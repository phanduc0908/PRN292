using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_DATA
{
    public class DataCategory
    {
        static public DataTable GetAllCategories()
        {
            string sql = "select * from Categories";
            return DataAccess.GetDataBySql(sql);
        }
    }
}
