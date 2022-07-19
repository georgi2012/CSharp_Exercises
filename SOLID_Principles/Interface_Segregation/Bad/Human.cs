using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Bad
{
    class Human : IWorker
    {
        public void Eat()
        {
            //eat
        }

        public void GetPaid(decimal sum)
        {
            //enjoy
        }

        public void Work()
        {
            //do work
        }
    }
}
