using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Dal
{
    public class CreateNewRouteAndAssignOwner
    {
        public void Execute(string companyId, string routeStart, string routeEnd)
        {
            using (var context = new AirportDbEntities1())
                context.CreateRouteAndAssignOwner( companyId, routeStart, routeEnd);
        }
    }
}
