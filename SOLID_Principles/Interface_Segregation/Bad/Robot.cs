using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Bad
{
    class Robot : IWorker
    {
        public void Eat()
        { //not needed
            throw new NotImplementedException();
        }

        public void GetPaid(decimal sum)
        { //not needed
            throw new NotImplementedException();
        }

        public void Work()
        {
           //do work
        }
    }
}
