using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class NHANVIEN_BLL
    {
        private readonly NHANVIEN_DAL _nhanvienDal = new NHANVIEN_DAL();

        public DataTable load_nhanvien()
        {
            return _nhanvienDal.load_nhanvien();
        }

        public int insert_nhanvien(NHANVIEN_DTO nhanvienPublic)
        {
            return _nhanvienDal.insert_nhanvien(nhanvienPublic);
        }

        public int update_nhanvien(NHANVIEN_DTO nhanvienPublic)
        {
            return _nhanvienDal.update_nhanvien(nhanvienPublic);
        }

        public int delete_nhanvien(NHANVIEN_DTO nhanvienPublic)
        {
            return _nhanvienDal.delete_nhanvien(nhanvienPublic);
        }

        public int count_nhanvien()
        {
            return _nhanvienDal.count_nhanvien();
        }

        public DataTable Tim_nv(NHANVIEN_DTO nhanvienPublic)
        {
            return _nhanvienDal.Tim_nv(nhanvienPublic);
        }
        public DataTable TIM_TenNV_hoatdong(NHANVIEN_DTO nhanvienPublic)
        {
            return _nhanvienDal.TIM_TenNV_hoatdong(nhanvienPublic);
        }
        public int DELETE_NhanVien_TrangThai(NHANVIEN_DTO nhanvienPublic)
        {
            return _nhanvienDal.DELETE_NhanVien_TrangThai(nhanvienPublic);
        }
    }   
}


