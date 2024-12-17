using System.Data;
using DTO;

namespace DAL
{
    public class BAN_DAL
    {
        private readonly DBConnect _conn = new DBConnect();

        public DataTable load_ban()
        {
            var sql = @"LOAD_BAN";
            return _conn.Load_Data(sql);
        }

        public DataTable load_ban_trong()
        {
            var sql = @"LOAD_BAN_TRONG";
            return _conn.Load_Data(sql);
        }

        public DataTable load_ban_conguoi()
        {
            var sql = @"LOAD_BAN_CONGUOI";
            return _conn.Load_Data(sql);
        }

        public int insert_ban(BAN_DTO ban_public)
        {
            var parameter = 3;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@Ten";
            name[1] = "@TrangThai";
            name[2] = "@ThuTu";

            values[0] = ban_public.Ten;
            values[1] = ban_public.TrangThai;
            values[2] = ban_public.ThuTu;

            var sql = "INSERT_BAN";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int update_ban(BAN_DTO ban_public)
        {
            var parameter = 4; 
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaBan";       
            name[1] = "@Ten";
            name[2] = "@TrangThai";
            name[3] = "@ThuTu";

            values[0] = ban_public.MaBan;  
            values[1] = ban_public.Ten;
            values[2] = ban_public.TrangThai;
            values[3] = ban_public.ThuTu;

            var sql = "UPDATE_BAN";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int delete_ban(BAN_DTO ban_public)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaBan";
            values[0] = ban_public.MaBan;

            var sql = "DELETE_BAN";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int update_trangthaiban(BAN_DTO ban_public)
        {
            var parameter = 2;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaBan";
            name[1] = "@TrangThai";

            values[0] = ban_public.MaBan;
            values[1] = ban_public.TrangThai;

            var sql = "UPDATE_trangthaiban";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

    }
}
