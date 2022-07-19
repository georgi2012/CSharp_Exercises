using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.Bad
{
    public class Manager
    {

        private readonly IWorker worker;

        public Manager()
        {
            this.worker = new Worker() ;
            //what if the allocation fails ?
            //class will be in invalid state
            //we have less control  on what is created
            //How are we supposed to test it?
            //It's not really Manager's job to hire/find workers, it's HR's or someone else
        }

        public void Manage()
        {
            this.worker.Work();
        }
    }
}
