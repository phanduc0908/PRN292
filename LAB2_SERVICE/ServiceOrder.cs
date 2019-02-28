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
    public class ServiceOrder
    {
        public static List<Order> GetAllOrders()
        {
            DataTable dt = new DataTable();
            List<Order> ordList = new List<Order>();
            dt = DataOrder.GetAllOrders();
            foreach (DataRow dr in dt.Rows)
            {
                ordList.Add(new Order(
                    Convert.ToInt32(dr["OrderID"]),
                    dr["ShipName"].ToString(),
                    dr["ShipAddress"].ToString()
                    ));
            }

            return ordList;
        }
    }
}
