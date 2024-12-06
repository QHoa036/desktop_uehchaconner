using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        public static SqlConnection Connect()
        {
            string strcon = @"";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
}
