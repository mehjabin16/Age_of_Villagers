using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BangladeshiHouse : CompositeShape
    {
        //private Panel Drawingpanel;
        //private Point point;
        public BangladeshiHouse(Point point)
        {

            addshape(new Rectangle(point.X, point.Y, point.X + 16, point.Y, point.X, point.Y + 16, point.X + 16, point.Y + 16));
            
            addshape(new Triangle(point.X + 8, point.Y - 8, point.X, point.Y, point.X + 16, point.Y));
            
        }

        /*public new void Draw(Point point, Panel Drawingpanel)
        {
           // g.DrawLine(p, point.X, point.Y, point.X + 24, point.Y);
           // g.DrawLine(p, point.X + 24, point.Y, point.X + 24, point.Y + 16);
           // g.DrawLine(p, point.X, point.Y + 16, point.X + 24, point.Y + 16);
           // g.DrawLine(p, point.X, point.Y, point.X, point.Y + 16);
           // g.DrawLine(p, point.X, point.Y, point.X + 12, point.Y-8);
           // g.DrawLine(p, point.X + 24, point.Y, point.X + 12, point.Y - 8);
        }*/
    }
}
