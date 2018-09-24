using EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    public interface IPaymentRepository:IRepository<Payment>
    {

        List<Payment> FindByPaymentId(int keyword);
    }
}
