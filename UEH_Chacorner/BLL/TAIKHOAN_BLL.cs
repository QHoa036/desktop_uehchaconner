using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class TAIKHOAN_BLL
    {
        private readonly TAIKHOAN_DAL _nhanvienDal = new TAIKHOAN_DAL();

        public DataTable load_taikhoan()
        {
            return _nhanvienDal.load_taikhoan();
        }

        public int check_taikhoan(TAIKHOAN_DTO account)
        {
            return _nhanvienDal.check_taikhoan(account);
        }

        public int insert_taikhoan(TAIKHOAN_DTO account)
        {
            return _nhanvienDal.insert_taikhoan(account);
        }

        public int update_taikhoan(TAIKHOAN_DTO account)
        {
            return _nhanvienDal.update_taikhoan(account);
        }

        public int delete_taikhoan(TAIKHOAN_DTO account)
        {
            return _nhanvienDal.delete_taikhoan(account);
        }

        public DataTable get_tenvaquyen_taikhoan(TAIKHOAN_DTO account)
        {
            return _nhanvienDal.get_tenvaquyen_taikhoan(account);
        }   
    }
}
