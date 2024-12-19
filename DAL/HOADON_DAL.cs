using System.Data;
using DTO;

namespace DAL
{
    public class HOADON_DAL
    {
        private readonly DBConnect _conn = new DBConnect();

        public DataTable load_hoadon()
        {
            var sql = @"LOAD_HoaDon";
            return _conn.Load_Data(sql);
        }

        public int load_hoadon_with_maban(HOADON_DTO hoadonPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaBan";
            values[0] = hoadonPublic.MaBan;

            var sql = @"LOAD_HoaDon_WITH_MaBan";
            return _conn.ReturnValueIntWithParameter(sql, name, values, parameter);
        }

        public int insert_hoadon(HOADON_DTO hoadonPublic)
        {
            var parameter = 4;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaBan";
            name[1] = "@MaNV";
            name[2] = "@NgayLap";
            name[3] = "@TrangThai";

            values[0] = hoadonPublic.MaBan;
            values[1] = hoadonPublic.MaNV;
            values[2] = hoadonPublic.NgayLap;
            values[3] = hoadonPublic.TrangThai;

            var sql = "INSERT_HoaDon";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int update_hoadon(HOADON_DTO hoadonPublic)
        {
            var parameter = 5;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaHD";
            name[1] = "@MaBan";
            name[2] = "@MaNV";
            name[3] = "@NgayLap";
            name[4] = "@TrangThai";

            values[0] = hoadonPublic.MaHD;
            values[1] = hoadonPublic.MaBan;
            values[2] = hoadonPublic.MaNV;
            values[3] = hoadonPublic.NgayLap;
            values[4] = hoadonPublic.TrangThai;

            var sql = "UPDATE_HoaDon";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int delete_hoadon(HOADON_DTO hoadonPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaHD";
            values[0] = hoadonPublic.MaHD;

            var sql = "DELETE_HoaDon";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int count_hoadon_ban(HOADON_DTO hoadonPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaBan";
            values[0] = hoadonPublic.MaBan;

            var sql = "DEMSOHD_OFBan";
            return _conn.ReturnValueIntWithParameter(sql, name, values, parameter);
        }

        public int update_hoadon_doiban(HOADON_DTO hoadonPublic)
        {
            var parameter = 2;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaHD";
            name[1] = "@MaBan";

            values[0] = hoadonPublic.MaHD;
            values[1] = hoadonPublic.MaBan;

            var sql = "UPDATE_HoaDon_doiban";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int delete_hoadon_with_maban(HOADON_DTO hoadonPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaBan";
            values[0] = hoadonPublic.MaBan;

            var sql = "DELETE_HoaDon_with_MaBan";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int load_hoadon_new(HOADON_DTO hoadonPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaBan";
            values[0] = hoadonPublic.MaBan;

            var sql = "Get_MaHD_New";
            return _conn.ReturnValueIntWithParameter(sql, name, values, parameter);
        }

    }
}
