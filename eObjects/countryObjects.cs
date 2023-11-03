using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eObjects
{
    public class countryObjects
    {
        // For store country Name
        private string Name;

        public string countryName
        {
            get { return Name; }
            set { Name = value; }
        }

        // For country Population
        private int Population;

        public int countryPopulation
        {
            get { return Population; }
            set { Population = value; }
        }

        // For official Language
        private string Language;

        public string countryLanguage
        {
            get { return Language; }
            set { Language = value; }
        }

        // For country Currency
        private string Currency;

        public string countryCurency
        {
            get { return Currency; }
            set { Currency = value; }
        }
    }
}
