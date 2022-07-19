using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Bad
{
    public interface IWorker
    {
        void Eat();

        void Work();

        void GetPaid(decimal sum);
    }
}
