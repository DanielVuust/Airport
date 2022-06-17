using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Dal
{
    public class DataManager
    {
        public List<Company> GetCompanies()
        {
            using (var context = new AirportDbEntities1())
                return context.Companies.ToList();
            
        }
    }
}
