using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Bad
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int Location { get; set; }
        
        public string TurnPage(int page)
        {
            return "Some page text";
        }
    }
}
