using EntityClass;
using InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : Repository<Customer>,ICustomerRepository
    {

        letsHikeDBContext context = new letsHikeDBContext();

        public List<Customer> FindByCustomer(int keyword)
        {
            return this.context.Customers.Where(p => p.Customer_Id == keyword).ToList();
        }


       

    }
}
