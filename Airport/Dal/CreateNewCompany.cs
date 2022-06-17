using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Dal
{
    public class CreateNewCompany
    {
        public void Execute(string name)
        {
            using (var context = new AirportDbEntities1())
            {
                context.CreateNewCompany(name);
            }
        }
    }
}
