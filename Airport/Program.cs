using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayManager displayManager = new DisplayManager();

            //Console.WriteLine("Create a new airport");
            //Console.WriteLine("IATA - Airport name - Airport Address");
            //CreateNewAirportManager createNewAirportManager = new CreateNewAirportManager();
            //createNewAirportManager.Execute(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            
            //Console.WriteLine();
            
            //Console.WriteLine("Create new company");
            //Console.WriteLine("Company name");
            //CreateNewCompanyManager createNewCompanyManager = new CreateNewCompanyManager();
            //createNewCompanyManager.Execute(Console.ReadLine());

            Console.WriteLine(displayManager.AllCompaniesStringBuilder());
            Console.WriteLine("Create new route and assign owner");
            Console.WriteLine("Company id - Route start - Route end");
            CreateNewRouteManager createNewRouteManager = new CreateNewRouteManager();
            createNewRouteManager.ExecuteWithOwnerId(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());


        }
    }
}
