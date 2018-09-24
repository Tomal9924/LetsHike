using EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    public interface IProductRepository :IRepository<Product>
    {
        List<Product> FindByProductId(int packageId);
    }
}
