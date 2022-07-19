using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Bad
{
    //well we know that a square is a rectangle, isnt it?
    public class Square : Rectangle
    {
        public override decimal Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override decimal Height { get => base.Height; set => base.Width = value; }
     
    }
}
