using System.Data;
using DTO;

namespace DAL
{
    public class NHANVIEN_DAL
    {
        private readonly DBConnect _conn = new DBConnect();

        public DataTable load_nhanvien()
        {
            var sql = @"LOAD_NHANVIEN";
            return _conn.Load_Data(sql);
        }

        public int insert_nhanvien(NHANVIEN_DTO nhanvienPublic)
        {
            var parameter = 5;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaNV";
            name[1] = "@TenNV";
            name[2] = "@NgaySinh";
            name[3] = "@SDT";
            name[4] = "@GioiTinh";

            values[0] = nhanvienPublic.MaNV;
            values[1] = nhanvienPublic.TenNV;
            values[2] = nhanvienPublic.NgaySinh;
            values[3] = nhanvienPublic.SDT;
            values[4] = nhanvienPublic.GioiTinh;

            var sql = "INSERT_NHANVIEN";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int update_nhanvien(NHANVIEN_DTO nhanvienPublic)
        {
            var parameter = 5;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaNV";
            name[1] = "@TenNV";
            name[2] = "@NgaySinh";
            name[3] = "@SDT";
            name[4] = "@GioiTinh";

            values[0] = nhanvienPublic.MaNV;
            values[1] = nhanvienPublic.TenNV;
            values[2] = nhanvienPublic.NgaySinh;
            values[3] = nhanvienPublic.SDT;
            values[4] = nhanvienPublic.GioiTinh;

            var sql = "UPDATE_NHANVIEN";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int delete_nhanvien(NHANVIEN_DTO nhanvienPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@IDNV";
            values[0] = nhanvienPublic.MaNV;

            var sql = "DELETE_NHANVIEN";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int count_nhanvien()
        {
            var sql = "COUNT_NHANVIEN";
            return _conn.ReturnValueInt(sql);
        }

        public DataTable Tim_nv(NHANVIEN_DTO nhanvienPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@TEN";
            values[0] = nhanvienPublic.TenNV;

            var sql = "TIM_TENNV";
            return _conn.LoadDataWithParameter(sql, name, values, parameter);
        }
    }
}
