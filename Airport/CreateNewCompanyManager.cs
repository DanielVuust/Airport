using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Dal;

namespace Airport
{
    public class CreateNewCompanyManager
    {
        public void Execute(string companyName)
        {
            CreateNewCompany createNewCompany = new CreateNewCompany();
            createNewCompany.Execute(companyName);
        }
    }
}
