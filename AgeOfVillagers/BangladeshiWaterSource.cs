using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{

    class BangladeshiWaterSource : CompositeShape
    {
        //private Panel Drawingpanel;

        public BangladeshiWaterSource(Point point)
        {
            
            addshape(new Line(point.X, point.Y, point.X + 24, point.Y - 30));
            addshape(new Line(point.X, point.Y, point.X + 26, point.Y + 30));
            addshape(new Line(point.X + 24, point.Y - 30, point.X + 46, point.Y - 33));
            addshape(new Line(point.X + 46, point.Y - 33, point.X + 50, point.Y - 20));
            addshape(new Line(point.X + 50, point.Y - 20, point.X + 70, point.Y - 36));
            addshape(new Line(point.X + 70, point.Y - 36, point.X + 90, point.Y - 10));
            addshape(new Line(point.X + 90, point.Y - 10, point.X + 65, point.Y + 15));
            addshape(new Line(point.X + 65, point.Y + 15, point.X + 55, point.Y + 5));
            addshape(new Line(point.X + 26, point.Y + 30, point.X + 55, point.Y + 5));
        }
        
    }
}
