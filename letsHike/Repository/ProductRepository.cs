using EntityClass;
using InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        letsHikeDBContext context = new letsHikeDBContext();

        public List<Product> FindByProductId(int keyword)
        {
            return this.context.Products.Where(p => p.Product_Id == keyword).ToList();
        }




    }
}
