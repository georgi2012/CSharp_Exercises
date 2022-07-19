using Open_Closed_Principle.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public abstract class SolidDrawingManager : IDrawingManagerSolid
    {

        public void Draw(IShape shape)
        {
            DrawShape(shape);
        }
        //now client decides which manager to use. 
        //He decides how they can be drawn. He decides what shapes will exist and so on
        protected abstract void DrawShape(IShape shape);
    }


}
