using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Bad
{
    class RobotSolid : IWorkerSolid
    {

        public void Work()
        {
           //do work
        }
    }
}
