using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Dal;

namespace Airport
{
    public class CreateNewRouteManager
    {
        public void ExecuteWithOwnerId(string companyId, string routeStart, string routeEnd)
        {
            CreateNewRouteAndAssignOwner newRoute = new CreateNewRouteAndAssignOwner();
            newRoute.Execute(companyId, routeStart, routeEnd);
        }
    }
}
