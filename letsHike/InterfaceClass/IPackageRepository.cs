using EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    public interface IPackageRepository : IRepository<Package>
    {
        List<Package> FindByPackageId(int packageId);
    }
}
