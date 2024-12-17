using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BAN_BLL
    {
        private readonly BAN_DAL _banDal = new BAN_DAL();
        
        public DataTable load_ban()
        {
            return _banDal.load_ban();
        }

        public DataTable load_ban_trong()
        {
            return _banDal.load_ban_trong();
        }

        public DataTable load_ban_conguoi()
        {
            return _banDal.load_ban_conguoi();
        }

        public int insert_ban(BAN_DTO banPublic)
        {            
            return _banDal.insert_ban(banPublic);
        }

        public int update_ban(BAN_DTO banPublic)
        {
            return _banDal.update_ban(banPublic);
        }
        public int update_trangthaiban(BAN_DTO banPublic)
        {
            return _banDal.update_trangthaiban(banPublic);
        }

        public int delete_ban(BAN_DTO banPublic)
        {
            return _banDal.delete_ban(banPublic);
        }

    }
}

