using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianHouse : CompositeShape
    {
        //private Panel Drawingpanel;

        public EgyptianHouse(Point point)
        {
            //this.Drawingpanel = Drawingpanel;
            addshape(new Line(point.X, point.Y, point.X + 25, point.Y - 15));
            addshape(new Line(point.X, point.Y, point.X - 30, point.Y - 10));
            addshape(new Line(point.X, point.Y, point.X - 10, point.Y - 30));
            addshape(new Line(point.X - 30, point.Y - 10, point.X - 10, point.Y - 30));
            addshape(new Line(point.X + 25, point.Y - 15, point.X - 10, point.Y - 30));
        }

        
    }
}
