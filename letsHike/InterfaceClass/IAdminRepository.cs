using EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    public interface IAdminRepository : IRepository<Admin>
    {
        List<Admin> FindByAdminId(int adminId);
    }
}
