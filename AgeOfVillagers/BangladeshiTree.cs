using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BangladeshiTree : CompositeShape
    {
        //private Panel Drawingpanel;
        public BangladeshiTree(Point point)
        {
            addshape(new Line(point.X + 8, point.Y + 16, point.X + 8, point.Y + 32));
            addshape(new Ellipse(point.X, point.Y, 16, 24));
        }

    }
}
