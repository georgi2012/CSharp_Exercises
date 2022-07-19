using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.GoodGreeting
{
    class Greeting
    {
        //now we can test it
        //
        private DateTime timeOfGreeting;

        public Greeting(DateTime dateTime)
        {
            this.timeOfGreeting = dateTime;
        }

        public Greeting()
            :this(DateTime.Now)
        {
            
        }

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
