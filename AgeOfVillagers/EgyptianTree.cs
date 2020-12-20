using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianTree : CompositeShape
    {
        //private Panel Drawingpanel;

        public EgyptianTree(Point point)
        {
            addshape(new Line(point.X, point.Y, point.X + 25, point.Y - 40));
            addshape(new Line(point.X, point.Y, point.X - 25, point.Y - 40));
            addshape(new Line(point.X + 19, point.Y - 28, point.X + 15, point.Y - 40));
            addshape(new Line(point.X + 19, point.Y - 28, point.X + 30, point.Y - 38));
            addshape(new Line(point.X - 19, point.Y - 30, point.X - 15, point.Y - 40));
            addshape(new Line(point.X - 19, point.Y - 30, point.X - 30, point.Y - 38));
        }
       
    }
}
