using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Dal
{
    public class CreateNewAirport
    {
        public void Execute(string IATA, string name, string address)
        {
            using (var context = new AirportDbEntities1())
            {
                context.CreateNewAirport(IATA, name, address);
            }
        }
    }
}
