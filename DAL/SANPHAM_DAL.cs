using System.Data;
using DTO;

namespace DAL
{
    public class SANPHAM_DAL
    {
        private readonly DBConnect _conn = new DBConnect();

        // Load danh sách sản phẩm
        public DataTable Load_SanPham()
        {
            var sql = @"LOAD_SanPham";
            return _conn.Load_Data(sql);
        }

        // Thêm sản phẩm
        public int Insert_SanPham(SANPHAM_DTO sanPhamPublic)
        {
            var parameter = 3; // Số lượng tham số
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@TenSanPham";
            name[1] = "@DonGia";
            name[2] = "@MaDMSP";

            values[0] = sanPhamPublic.TenSanPham;
            values[1] = sanPhamPublic.DonGia;
            values[2] = sanPhamPublic.MaDMSP;

            var sql = "INSERT_SanPham";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        // Cập nhật sản phẩm
        public int Update_SanPham(SANPHAM_DTO sanPhamPublic)
        {
            var parameter = 4;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaSP";
            name[1] = "@TenSP";
            name[2] = "@DonGia";
            name[3] = "@MaDMSP";

            values[0] = sanPhamPublic.MaSP;
            values[1] = sanPhamPublic.TenSanPham;
            values[2] = sanPhamPublic.DonGia;
            values[3] = sanPhamPublic.MaDMSP;

            var sql = "UPDATE_SanPham";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        // Xóa sản phẩm
        public int Delete_SanPham(SANPHAM_DTO sanPhamPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaSP";
            values[0] = sanPhamPublic.MaSP;

            var sql = "DELETE_SanPham";
            return _conn.ExecuteData(sql, name, values, parameter);
        }

        public int Load_Sanpham_WITH_DMSP(SANPHAM_DTO sanPhamPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaDMSP";
            values[0] = sanPhamPublic.MaDMSP;

            var sql = @"LOAD_SanPham_WITH_WHERE";
            return _conn.ReturnValueIntWithParameter(sql, name, values, parameter);
        }

        public int Load_Sanpham_ID(SANPHAM_DTO sanPhamPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@MaDMSP";
            values[0] = sanPhamPublic.MaDMSP;

            var sql = @"LOAD_SanPham_ID";
            return _conn.ReturnValueIntWithParameter(sql, name, values, parameter);
        }

        // Tìm kiếm sản phẩm theo tên
        public DataTable Tim_SanPham(SANPHAM_DTO sanPhamPublic)
        {
            var parameter = 1;
            var name = new string[parameter];
            var values = new object[parameter];

            name[0] = "@Ten";
            values[0] = sanPhamPublic.TenSanPham;

            var sql = "TIM_TenSanPham";
            return _conn.LoadDataWithParameter(sql, name, values, parameter);
        }
    }

}
