using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Good
{
    public class RectangleDrawingManager : SolidDrawingManager
    {
        protected override void DrawShape(IShape shape)
        {
            var rectangle = shape as Rectangle;
            //draw it
        }
    }
}
