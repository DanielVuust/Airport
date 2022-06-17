using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Dal;

namespace Airport
{
    public class CreateNewAirportManager
    {
        public void Execute(string IATA, string name, string address)
        {
            CreateNewAirport createNewAirport = new CreateNewAirport();
            createNewAirport.Execute(IATA, name, address);
        }
    }
}
