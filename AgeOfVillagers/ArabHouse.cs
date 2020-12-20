using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabHouse : CompositeShape
    {
        //private Panel Drawingpanel;

        public ArabHouse(Point point)
        {
            addshape(new Triangle(point.X + 15, point.Y - 30, point.X, point.Y, point.X + 30, point.Y));
            
            
            addshape(new Line(point.X + 15, point.Y - 30, point.X + 30, point.Y));
            addshape(new Line(point.X + 30, point.Y, point.X + 45, point.Y - 10));
            addshape(new Line(point.X + 45, point.Y - 10, point.X + 32, point.Y - 40));
            addshape(new Line(point.X + 15, point.Y - 30, point.X + 32, point.Y - 40));
            
        }
    }
        
    
}
