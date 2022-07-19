using Open_Closed_Principle.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class DrawingManager : IDrawingManager
    {
        //Single resp is valid.
        //what if we add more shapes? 
        //do we have to change our code again
        public void Draw(IShape shape)
        {
            if (shape is Circle)
            {
                DrawCircle(shape as Circle);
            }
            else if(shape is Rectangle)
            {
                DrawRectangle(shape as Rectangle);
            }
            //else ? nothing...
        }

        public void DrawCircle(Circle circle)
        {
            //do something
        }

        public void DrawRectangle(Rectangle rectangle)
        {
            //do something
        }
}
}
