using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        private readonly SqlConnection _connect = new SqlConnection(ConfigurationManager.ConnectionStrings[@"Local"].ConnectionString);

        public DBConnect()
        {
            if (_connect.State == ConnectionState.Closed) _connect.Open();
        }

        // Load dữ liệu từ database
        public DataTable Load_Data(string sql)
        {
            var cmd = new SqlCommand(sql, _connect) { CommandType = CommandType.StoredProcedure };
            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // Load dữ liệu từ database với tham số
        public DataTable LoadDataWithParameter(string sql, string[] name, object[] values, int parameter)
        {
            var cmd = new SqlCommand(sql, _connect) { CommandType = CommandType.StoredProcedure };
            for (var i = 0; i < parameter; i++) cmd.Parameters.AddWithValue(name[i], values[i]);
            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // Thêm, sửa, xóa dữ liệu
        public int ExecuteData(string sql, string[] name, object[] values, int parameter)
        {
            var cmd = new SqlCommand(sql, _connect) { CommandType = CommandType.StoredProcedure };
            for (var i = 0; i < parameter; i++) cmd.Parameters.AddWithValue(name[i], values[i]);
            return cmd.ExecuteNonQuery();
        }

        // Trả về giá trị
        public int ReturnValueInt(string sql)
        {
            var cmd = new SqlCommand(sql, _connect) { CommandType = CommandType.StoredProcedure };
            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        // Trả về giá trị với tham số
        public int ReturnValueIntWithParameter(string sql, string[] name, object[] values, int parameter)
        {
            var cmd = new SqlCommand(sql, _connect) { CommandType = CommandType.StoredProcedure };
            for (var i = 0; i < parameter; i++) cmd.Parameters.AddWithValue(name[i], values[i]);
            return int.Parse(cmd.ExecuteScalar().ToString());
        }
    }
}
