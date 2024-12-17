using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class SANPHAM_BLL
    {
        private readonly SANPHAM_DAL _sanphamDal = new SANPHAM_DAL();

        // Load danh sách sản phẩm
        public DataTable Load_SanPham()
        {
            return _sanphamDal.Load_SanPham();
        }

        // Thêm sản phẩm
        public int Insert_SanPham(SANPHAM_DTO sanPhamPublic)
        {
            return _sanphamDal.Insert_SanPham(sanPhamPublic);
        }

        // Cập nhật sản phẩm
        public int Update_SanPham(SANPHAM_DTO sanPhamPublic)
        {
            return _sanphamDal.Update_SanPham(sanPhamPublic);
        }

        // Xóa sản phẩm
        public int Delete_SanPham(SANPHAM_DTO sanPhamPublic)
        {
            return _sanphamDal.Delete_SanPham(sanPhamPublic);
        }

        public int load_sanpham_with_dmsp(SANPHAM_DTO sanPhamPublic)
        {
            return _sanphamDal.Load_Sanpham_WITH_DMSP(sanPhamPublic);
        }

        public int load_sanpham_id(SANPHAM_DTO sanPhamPublic)
        {
            return _sanphamDal.Load_Sanpham_ID(sanPhamPublic);
        }


        // Tìm kiếm sản phẩm theo tên
        public DataTable Tim_SanPham(SANPHAM_DTO sanPhamPublic)
        {
            return _sanphamDal.Tim_SanPham(sanPhamPublic);
        }

    }
}