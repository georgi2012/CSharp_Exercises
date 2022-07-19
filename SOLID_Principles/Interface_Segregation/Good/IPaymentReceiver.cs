using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Good
{
    public interface IPaymentReceiver
    {
        void GetPaid(decimal sum);
    }
}
