using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Bad
{
    //well we know that a square is a rectangle, isnt it?
    public class SquareSolid : Shape
    {
       public decimal Side { get; set; }

        public override decimal Area => Side * Side;
    }
}
