using EntityClass;
using InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PackageRepository : Repository<Package>, IPackageRepository
    {

        letsHikeDBContext context = new letsHikeDBContext();

       
        public List<Package> FindByPackageId(int keyword)
        {
            return this.context.Packages.Where(p => p.Package_Id == keyword).ToList();
        }




    }
}
