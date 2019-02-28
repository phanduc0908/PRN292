using LAB2_CORE;
using LAB2_DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_SERVICE
{
    public class ServiceSupplier
    {
        public static List<Supplier> GetSuppliers()
        {
            DataTable dt = new DataTable();
            List<Supplier> supList = new List<Supplier>();
            dt = DataSupplier.GetAllSuppliers();
            foreach(DataRow dr in dt.Rows)
            {
                supList.Add(new Supplier(
                    Convert.ToInt32(dr["SupplierID"]),
                    dr["CompanyName"].ToString(),
                    dr["ContactName"].ToString(),
                    dr["Address"].ToString()
                    ));
            }
            return supList;
        }
    }
}
