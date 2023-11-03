using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bLogic; // Business Logic Reference
using eObjects; // Entity Objects Reference

namespace uView
{
    public class userView
    {
        public void takeInput()
        {
            // Take Input for country object
            Console.WriteLine("Enter the name of your Country: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the population of your Countrry: ");
            int popu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the language of your country: ");
            string lang = Console.ReadLine();

            Console.WriteLine("Enter the currency of your country: ");
            string curr = Console.ReadLine();
 

            // Now create country Object and store the input into relevent fields
            countryObjects country = new countryObjects();
            country.countryName = name;
            country.countryPopulation = popu;
            country.countryLanguage = lang;
            country.countryCurency = curr;
            // Data Stored in country relevent fields


            //Now get input for person object
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine(); // already declare variable use again

            Console.WriteLine("Enter your salary: ");
            double sal = double.Parse(Console.ReadLine());

            // Now create Person Object
            personObject person = new personObject();
            person.personName = name;
            person.personSalary = sal;
            person.personCountry = country;

            //Now create the Business Logic Object
            businessLogic logic = new businessLogic();
            logic.wProcess(person);
        
        }

        public void Display()
        {
            businessLogic bLog = new businessLogic();
            personObject per = bLog.rProcess();
            
            Console.WriteLine("\n\n******  Output  ******\n");
            Console.WriteLine("Person Name: {0}", per.personName);
            Console.WriteLine("Person Salary {0}: ", per.personSalary);
            Console.WriteLine("Tax on salary: {0}", per.personTax);
            Console.WriteLine("Person Country: {0}", per.personCountry.countryName);
            Console.WriteLine("Person's Country Language: {0}", per.personCountry.countryLanguage);
            Console.WriteLine("Person's Country Population: {0}", per.personCountry.countryPopulation);
            Console.WriteLine("People's Country Currency: {0}", per.personCountry.countryCurency);
            Console.ReadKey();

        }
    }
}
