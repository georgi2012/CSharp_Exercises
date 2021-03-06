using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Bad
{
    public class RectangleSolid : ShapeSolid
    {
        public virtual decimal Width { get; set; }
       
        public virtual decimal Height { get; set; }

        public override decimal Area => this.Width * this.Height;
    }
    
}
