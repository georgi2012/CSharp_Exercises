using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.Bad
{
    class WorkerSolid : IWorker
    {
        public void Work()
        {
            //work
        }
    }
}
