using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.Bad
{
    public class ManagerSolid
    {

        private readonly IWorker worker;

        //optional - property injection
        //make the worker public and settable
        //method injection - if just one function needs it,
        //it can be passed as a paramether

        public ManagerSolid(IWorker worker)
        {
            this.worker = worker;
            //always valid state
        }

        //optional - Poor Man's Dependency Injection
        public ManagerSolid()
            :this(new Worker())
        {

        }

        public void Manage()
        {
            this.worker.Work();
        }
    }
}
