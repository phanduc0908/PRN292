using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_DATA
{
    public class DataProduct
    {
        static public DataTable GetAllProducts()
        {
            string sql = "select * from Products";
            return DataAccess.GetDataBySql(sql);
        }

        static public DataTable GetProductByCatID(int CatID)
        {
            string sql = "select * from Products where CategoryID = " + CatID.ToString();
            return DataAccess.GetDataBySql(sql);
        }



        static public int DeleteProduct(int ProductID)
        {
            string sql = "delete from [Order Details] where ProductID = " + ProductID.ToString();
            DataAccess.ExecuteQuery(sql);
            sql = "delete from Products where ProductID = " + ProductID.ToString();
            return DataAccess.ExecuteQuery(sql);
        }

        static public DataRow GetProductByID(int ProductID)
        {
            string sql = "select * from Products where ProductID = " + ProductID.ToString();
            return DataAccess.GetDataBySql(sql).Rows[0];
        }

        static public int EditProduct(int productid, string productname, int catid,int supId, double price, bool discontinue)
        {
            string sql = @"update Products set 
                ProductName = @name, 
                CategoryID = @cat,
                SupplierID = @sup,
                UnitPrice = @price,
                Discontinued = @discon where ProductID = @id";
            SqlCommand command = new SqlCommand(sql, DataAccess.GetConnection());
            command.Connection.Open();

            SqlParameter param1 = new SqlParameter("@name", SqlDbType.NVarChar);
            param1.Value = productname;
            command.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@cat", SqlDbType.Int);
            param2.Value = catid;
            command.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@sup", SqlDbType.Int);
            param3.Value = supId;
            command.Parameters.Add(param3);

            SqlParameter param4 = new SqlParameter("@price", SqlDbType.Money);
            param4.Value = price;
            command.Parameters.Add(param4);

            SqlParameter param5 = new SqlParameter("@discon", SqlDbType.Bit);
            param5.Value = discontinue;
            command.Parameters.Add(param5);

            SqlParameter param6 = new SqlParameter("@id", SqlDbType.Int);
            param6.Value = productid;
            command.Parameters.Add(param6);


            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
        static public int CreateProduct(string productname, int catid, int supId, double price, bool discontinue)
        {
            string sql = @"insert into Products (ProductName,CategoryID, SupplierID,UnitPrice, Discontinued) 
                            values(@name,@cat,@sup,@price,@discon)";
            SqlCommand command = new SqlCommand(sql, DataAccess.GetConnection());
            command.Connection.Open();

            SqlParameter param1 = new SqlParameter("@name", SqlDbType.NVarChar);
            param1.Value = productname;
            command.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@cat", SqlDbType.Int);
            param2.Value = catid;
            command.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@sup", SqlDbType.Int);
            param3.Value = supId;
            command.Parameters.Add(param3);

            SqlParameter param4 = new SqlParameter("@price", SqlDbType.Money);
            param4.Value = price;
            command.Parameters.Add(param4);

            SqlParameter param5 = new SqlParameter("@discon", SqlDbType.Bit);
            param5.Value = discontinue;
            command.Parameters.Add(param5);

            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
    }
}
