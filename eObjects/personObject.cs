using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eObjects
{
    public class personObject
    {
        private string Name;

        public string personName
        {
            get { return Name; }
            set { Name = value; }
        }

        private double Salary;

        public double personSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        private double Tax;

        public double personTax
        {
            get { return Tax; }
            set { Tax = value; }
        }

        private countryObjects Country = new countryObjects();

        public countryObjects personCountry
        {
            get { return Country; }
            set { Country = value; }
        }

       
    }
}
