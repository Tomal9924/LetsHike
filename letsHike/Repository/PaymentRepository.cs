using EntityClass;
using InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {

        letsHikeDBContext context = new letsHikeDBContext();

        public List<Payment> FindByPaymentId(int keyword)
        {
            return this.context.Payments.Where(p => p.Payment_Id == keyword).ToList();
        }




    }
}
