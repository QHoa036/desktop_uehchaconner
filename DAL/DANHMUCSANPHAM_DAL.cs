using System.Data;
using DTO;

namespace DAL
{
    public class DANHMUCSANPHAM_DAL
    {
        private readonly DBConnect _conn = new DBConnect();

        // Load danh sách danh mục sản phẩm
        public DataTable Load_DanhMucSanPham()
        {
            var sql = @"LOAD_DanhMucSanPham";
            return _conn.Load_Data(sql);
        }

        // Thêm danh mục sản phẩm
        public int Insert_DanhMucSanPham(DANHMUCSANPHAM_DTO danhMucPublic)
        {
            var parameter = 1; // Số lượng tham số
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@TenDMSP";

            values[0] = danhMucPublic.TenDMSP;

            var sql = "INSERT_DanhMucSanPham";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        // Cập nhật danh mục sản phẩm
        public int Update_DanhMucSanPham(DANHMUCSANPHAM_DTO danhMucPublic)
        {
            var parameter = 2;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaDMSP";
            name[1] = "@TenDMSP";

            values[0] = danhMucPublic.MaDMSP;
            values[1] = danhMucPublic.TenDMSP;

            var sql = "UPDATE_DanhMucSanPham";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        // Xóa danh mục sản phẩm
        public int Delete_DanhMucSanPham(DANHMUCSANPHAM_DTO danhMucPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaDMSP";
            values[0] = danhMucPublic.MaDMSP;

            var sql = "DELETE_DanhMucSanPham";
            return _conn.ExecuteData(sql, name, values, parameter);
        }
    }
}
