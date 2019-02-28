using System.Data;
using System.Data.SqlClient;

namespace LAB2_DATA
{
    public class DataAccess
    {
        static public SqlConnection GetConnection()
        {
            string ConnectionString = @"server=localhost;database=Northwind;user=sa;password=123456";
            return new SqlConnection(ConnectionString);
        }

        static public DataTable GetDataBySql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        static public int ExecuteQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Connection.Open();
            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
    }
}
