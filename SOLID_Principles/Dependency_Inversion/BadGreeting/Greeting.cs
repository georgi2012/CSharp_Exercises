using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.BadGreeting
{
    class Greeting
    {
        //not testable.
        public string Greet(string name)
        {
            if (DateTime.Now.Hour < 12)
            {
                return "Good morning, " + name;
            }
            else if (DateTime.Now.Hour < 18)
            {
                return "Good afternoon, " + name;
            }
            return "Good evening, " + name;
        }
    }
}
