using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class DANHMUCSANPHAM_BLL
    {
        private readonly DANHMUCSANPHAM_DAL _danhMucDal = new DANHMUCSANPHAM_DAL();

        // Load danh sách danh mục sản phẩm
        public DataTable Load_DanhMucSanPham()
        {
            return _danhMucDal.Load_DanhMucSanPham();
        }

        // Thêm danh mục sản phẩm
        public int Insert_DanhMucSanPham(DANHMUCSANPHAM_DTO danhMucPublic)
        {
            return _danhMucDal.Insert_DanhMucSanPham(danhMucPublic);
        }

        // Cập nhật danh mục sản phẩm
        public int Update_DanhMucSanPham(DANHMUCSANPHAM_DTO danhMucPublic)
        {
            return _danhMucDal.Update_DanhMucSanPham(danhMucPublic);
        }

        // Xóa danh mục sản phẩm
        public int Delete_DanhMucSanPham(DANHMUCSANPHAM_DTO danhMucPublic)
        {
            return _danhMucDal.Delete_DanhMucSanPham(danhMucPublic);
        }
    }
}