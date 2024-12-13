using System.Data;
using DTO;

namespace DAL
{
    public class CTHD_DAL
    {
        private readonly DBConnect _conn = new DBConnect();

        public DataTable load_cthd(CTHD_DTO cthdPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaHD";
            values[0] = cthdPublic.MaHD;

            var sql = "LOAD_CTHD";
            return _conn.LoadDataWithParameter(sql, name, values, parameter);
        }

        public DataTable load_cthd_thanhtoan(CTHD_DTO cthdPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaHD";
            values[0] = cthdPublic.MaHD;

            var sql = "LOAD_CTHD_thanhtoan";
            return _conn.LoadDataWithParameter(sql, name, values, parameter);
        }

        public int insert_cthd(CTHD_DTO cthdPublic)
        {
            var parameter = 3;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaHD";
            name[1] = "@MaSP";
            name[2] = "@SoLuong";

            values[0] = cthdPublic.MaHD;
            values[1] = cthdPublic.MaSP;
            values[2] = cthdPublic.SoLuong;

            var sql = "INSERT_CTHD";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int update_cthd(CTHD_DTO cthdPublic)
        {
            var parameter = 4;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaCTHD";
            name[1] = "@MaHD";
            name[2] = "@MaSP";
            name[3] = "@SoLuong";

            values[0] = cthdPublic.MaCTHD;
            values[1] = cthdPublic.MaHD;
            values[2] = cthdPublic.MaSP;
            values[3] = cthdPublic.SoLuong;

            var sql = "UPDATE_CTHD";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int delete_cthd(CTHD_DTO cthdPublic)
        {
            var parameter = 2;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaHD";
            name[1] = "@MaSP";

            values[0] = cthdPublic.MaHD;
            values[1] = cthdPublic.MaSP;

            var sql = "DELETE_CTHD";
            return _conn.ExecuteData(sql, name, values, parameter);
        }
    }
}
