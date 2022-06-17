using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Dal;

namespace Airport
{
    public class DisplayManager
    {
        public StringBuilder AllCompaniesStringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            DataManager dataManager = new DataManager();
            List<Company> companies = dataManager.GetCompanies();
            foreach (Company company in companies)
            {
                stringBuilder.Append(company.CompanyId + " " + company.CompanyName);
            }

            return stringBuilder;
        }
    }
}
