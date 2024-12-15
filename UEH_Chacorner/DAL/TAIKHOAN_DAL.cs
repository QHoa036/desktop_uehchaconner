using System;
using System.Data;

using DTO;  

namespace DAL
{
    public class TAIKHOAN_DAL
    {
        private readonly DBConnect _conn = new DBConnect();

        public DataTable load_taikhoan()
        {
            var sql = @"LOAD_TaiKhoan";
            return _conn.Load_Data(sql);
        }
        public int check_taikhoan(TAIKHOAN_DTO account)
        {
            var parameter = 2;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@TenTK";
            name[1] = "@MatKhau";
            values[0] = account.TenTK;
            values[1] = account.MatKhau;

            var sql = "CHECK_TaiKhoan";
            return _conn.ReturnValueIntWithParameter(sql, name, values, parameter);
        }

        public int insert_taikhoan(TAIKHOAN_DTO account)
        {
            var parameter = 4;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@TenTK";
            name[1] = "@MatKhau";
            name[2] = "@Quyen";
            name[3] = "@MaNV";
            values[0] = account.TenTK;
            values[1] = account.MatKhau;
            values[2] = account.Quyen;
            values[3] = account.MaNV;

            var sql = "INSERT_TaiKhoan";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int update_taikhoan(TAIKHOAN_DTO account)
        {
            var parameter = 4;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@TenTK";
            name[1] = "@MatKhau";
            name[2] = "@Quyen";
            name[3] = "@MaNV";
            values[0] = account.TenTK;
            values[1] = account.MatKhau;
            values[2] = account.Quyen;
            values[3] = account.MaNV;

            var sql = "UPDATE_TaiKhoan";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int delete_taikhoan(TAIKHOAN_DTO account)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaNV"; 
            values[0] = account.MaNV;

            var sql = "DELETE_TaiKhoan";

            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public DataTable get_tenvaquyen_taikhoan(TAIKHOAN_DTO account)
        {
            var parameter = 2;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@TenTK";
            name[1] = "@MatKhau";
            values[0] = account.TenTK;
            values[1] = account.MatKhau;

            var sql = "GET_TenVAQuyen_TaiKhoan";
            return _conn.LoadDataWithParameter(sql, name, values, parameter);
        }
    }
}
