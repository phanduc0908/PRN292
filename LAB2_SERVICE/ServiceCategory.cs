using LAB2_CORE;
using LAB2_DATA;
using System;
using System.Collections.Generic;
using System.Data;

namespace LAB2_SERVICE
{
    public class ServiceCategory
    {
        public static List<Category> GetCategories()
        {
            DataTable dt = new DataTable();
            List<Category> catList = new List<Category>();
            dt = DataCategory.GetAllCategories();
            foreach (DataRow dr in dt.Rows)
            {
                catList.Add(new Category(
                    Convert.ToInt32(dr["CategoryID"]),
                    dr["CategoryName"].ToString()
                    ));
            }
            return catList;
        }
    }
}
