using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uView; //Add view reference

namespace nTiersApplicationPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            userView view = new userView();
            view.takeInput();
            view.Display();
        }
    }
}
