using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class HOADON_BLL
    {
        private readonly HOADON_DAL _hoadonDal = new HOADON_DAL();

        public DataTable load_hoadon()
        {
            return _hoadonDal.load_hoadon();
        }

        public int insert_hoadon(HOADON_DTO hoadonPublic)
        {
            return _hoadonDal.insert_hoadon(hoadonPublic);
        }

        public int update_hoadon(HOADON_DTO hoadonPublic)
        {
            return _hoadonDal.update_hoadon(hoadonPublic);
        }

        public int delete_hoadon(HOADON_DTO hoadonPublic)
        {
            return _hoadonDal.delete_hoadon(hoadonPublic);
        }

        public int count_hoadon_ban(HOADON_DTO hoadonPublic)
        {
            return _hoadonDal.count_hoadon_ban(hoadonPublic);
        }

        public int delete_hoadon_with_maban(HOADON_DTO HOADON_DTO)
        {
            return _hoadonDal.delete_hoadon_with_maban(HOADON_DTO);
        }

        public int load_hoadon_with_maban(HOADON_DTO hd_public)
        {
            return _hoadonDal.load_hoadon_with_maban(hd_public);
        }

        public int update_hoadon_doiban(HOADON_DTO HOADON_DTO)
        {
            return _hoadonDal.update_hoadon_doiban(HOADON_DTO);
        }
    }
}
