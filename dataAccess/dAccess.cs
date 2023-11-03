using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eObjects;
using System.IO; // For entity objects

namespace dataAccess
{
    public class dAccess
    {
        public void saveInFile(personObject per)
        {
            FileStream fin = new FileStream("Person.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fin);

            string wData = per.personName + ";" + per.personSalary + ";" + per.personTax + ";" + per.personCountry.countryName + ";" 
                + per.personCountry.countryLanguage + ";" + per.personCountry.countryPopulation + ";" + per.personCountry.countryCurency;

            sw.WriteLine(wData);

            sw.Close();
            fin.Close();
        }

        public personObject readFromFile()
        {
            FileStream fout = new FileStream("Person.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fout);

            string rData = sr.ReadLine();
            string[] data = rData.Split(';');

            personObject pObj = new personObject();
            
            pObj.personName = data[0];
            pObj.personSalary = double.Parse(data[1]);
            pObj.personTax = double.Parse(data[2]);
            pObj.personCountry.countryName = data[3];
            pObj.personCountry.countryLanguage = data[4];
            pObj.personCountry.countryPopulation = Convert.ToInt32(data[5]);
            pObj.personCountry.countryCurency = data[6];

            return pObj;
        }
    }
}