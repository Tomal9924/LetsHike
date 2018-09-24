using EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        //List<Customer> Search(string keyword);
        List<Customer> FindByCustomer(int keyword);
    }
}
