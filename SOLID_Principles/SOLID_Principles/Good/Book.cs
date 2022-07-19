using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Good
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        //in some cases, we can make a PageTurner class as well
        public string TurnPage(int page)
        {
            return "Some page text";
        }
    }
}
