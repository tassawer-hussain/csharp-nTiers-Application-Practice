using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataAccess;
using eObjects;


namespace bLogic
{
    public class businessLogic
    {
        public void wProcess(personObject per)
        {
            // call calTax Method
            per.personTax = calTax(per);
            // Here we solved our logic and now create data access object

            dAccess DAL = new dAccess();
            //Call the save in file Method for save data
            DAL.saveInFile(per);
        }

        // Business Logic
        public double calTax(personObject per)
        {
            return per.personSalary * 0.16;
        }

        // Read Function from Data Access Layer
        public personObject rProcess()
        {
            dAccess dAcc = new dAccess();
            personObject pOb = new personObject();
            pOb = dAcc.readFromFile();

            return pOb;
        }
    }
}
