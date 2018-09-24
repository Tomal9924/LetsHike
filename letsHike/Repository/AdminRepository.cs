using EntityClass;
using InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {

        letsHikeDBContext context = new letsHikeDBContext();

        public List<Admin> FindByAdminId(int keyword)
        {
            return this.context.Admins.Where(p => p.Admin_Id == keyword).ToList();
        }




    }
}
