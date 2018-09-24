using EntityClass;
using InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TravellerRepository : Repository<Traveller>, ITravellerRepository
    {

        letsHikeDBContext context = new letsHikeDBContext();

        public List<Traveller> FindByTravellerId(int keyword)
        {
            return this.context.Travellers.Where(p => p.Traveller_Id == keyword).ToList();
        }




    }
}
