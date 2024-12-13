using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class CTHD_BLL
    {
        private readonly CTHD_DAL _cthdDal = new CTHD_DAL();

        public DataTable load_cthd(CTHD_DTO cthdPublic)
        {
            return _cthdDal.load_cthd(cthdPublic);
        }

        public int insert_cthd(CTHD_DTO cthdPublic)
        {
            return _cthdDal.insert_cthd(cthdPublic);
        }

        public int update_cthd(CTHD_DTO cthdPublic)
        {
            return _cthdDal.update_cthd(cthdPublic);
        }

        public int delete_cthd(CTHD_DTO cthdPublic)
        {
            return _cthdDal.delete_cthd(cthdPublic);
        }

        public DataTable load_cthd_thanhtoan(CTHD_DTO cthdPublic)
        {
            return _cthdDal.load_cthd_thanhtoan(cthdPublic);
        }
    }
}
