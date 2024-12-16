using System.Data;
using DTO;

namespace DAL
{
    public class NHANVIEN_DAL
    {
        private readonly DBConnect _conn = new DBConnect();

        public DataTable load_nhanvien()
        {
            var sql = @"LOAD_NhanVien";
            return _conn.Load_Data(sql);
        }

        public int insert_nhanvien(NHANVIEN_DTO nhanvienPublic)
        {
            var parameter = 6;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaNV";
            name[1] = "@TenNV";
            name[2] = "@NgaySinh";
            name[3] = "@SDT";
            name[4] = "@GioiTinh";
            name[5] = "@TrangThai";

            values[0] = nhanvienPublic.MaNV;
            values[1] = nhanvienPublic.TenNV;
            values[2] = nhanvienPublic.NgaySinh;
            values[3] = nhanvienPublic.SDT;
            values[4] = nhanvienPublic.GioiTinh;
            values[5] = nhanvienPublic.TrangThai;

            var sql = "INSERT_NhanVien";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int update_nhanvien(NHANVIEN_DTO nhanvienPublic)
        {
            var parameter = 6;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaNV";
            name[1] = "@TenNV";
            name[2] = "@NgaySinh";
            name[3] = "@SDT";
            name[4] = "@GioiTinh";
            name[5] = "@TrangThai";

            values[0] = nhanvienPublic.MaNV;
            values[1] = nhanvienPublic.TenNV;
            values[2] = nhanvienPublic.NgaySinh;
            values[3] = nhanvienPublic.SDT;
            values[4] = nhanvienPublic.GioiTinh;
            values[5] = nhanvienPublic.TrangThai;

            var sql = "UPDATE_NhanVien";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int delete_nhanvien(NHANVIEN_DTO nhanvienPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaNV";
            values[0] = nhanvienPublic.MaNV;

            var sql = "DELETE_NhanVien";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int count_nhanvien()
        {
            var sql = "COUNT_NhanVien";
            return _conn.ReturnValueInt(sql);
        }

        public DataTable Tim_nv(NHANVIEN_DTO nhanvienPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@Ten";
            values[0] = nhanvienPublic.TenNV;

            var sql = "TIM_TenNV";
            return _conn.LoadDataWithParameter(sql, name, values, parameter);
        }

        public DataTable TIM_TenNV_hoatdong(NHANVIEN_DTO nhanvienPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@Ten";
            values[0] = nhanvienPublic.TenNV;

            var sql = "TIM_TenNV_hoatdong";
            return _conn.LoadDataWithParameter(sql, name, values, parameter);
        }
        public int DELETE_NhanVien_TrangThai(NHANVIEN_DTO nhanvienPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaNV";
            values[0] = nhanvienPublic.MaNV;

            var sql = "DELETE_NhanVien_TrangThai";
            return _conn.ExecuteData(sql, name, values, parameter);
        }
        
    }
}
