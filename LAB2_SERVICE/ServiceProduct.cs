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
    public class ServiceProduct
    {
        public static List<Product> GetAllProducts()
        {
            DataTable dt = new DataTable();
            List<Product> proList = new List<Product>();
            dt = DataProduct.GetAllProducts();
            foreach (DataRow dr in dt.Rows)
            {
                proList.Add(new Product(
                    Convert.ToInt32(dr["ProductID"]),
                    dr["ProductName"].ToString(),
                    Convert.ToInt32(dr["SupplierID"]),
                    Convert.ToInt32(dr["CategoryID"]),
                    Convert.ToDouble(dr["UnitPrice"]),
                    Convert.ToBoolean(dr["Discontinued"])
                    ));
            }

            return proList;
        }
        public static Product GetProductByID(int ProductID)
        {
            DataRow dr = DataProduct.GetProductByID(ProductID);
            return new Product(
                    Convert.ToInt32(dr["ProductID"]),
                    dr["ProductName"].ToString(),
                    Convert.ToInt32(dr["SupplierID"]),
                    Convert.ToInt32(dr["CategoryID"]),
                    Convert.ToDouble(dr["UnitPrice"]),
                    Convert.ToBoolean(dr["Discontinued"])
                    );
        }

        public static int UpdateProduct(int productID, string productName, int catID, int supID, double price, bool discontinue)
        {
            return DataProduct.EditProduct(productID, productName, catID, supID, price, discontinue);
        }

        public static int CreateProduct(string productName, int catID, int supID, double price, bool discontinue)
        {
            return DataProduct.CreateProduct( productName, catID, supID, price, discontinue);
        }
    }
}
