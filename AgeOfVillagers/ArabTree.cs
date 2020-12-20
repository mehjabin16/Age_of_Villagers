using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ArabTree : CompositeShape
    {
        //private Panel Drawingpanel;

        public ArabTree(Point point)
        {
            addshape(new Line(point.X, point.Y, point.X + 4, point.Y));
            addshape(new Line(point.X, point.Y, point.X, point.Y - 30));
            addshape(new Line(point.X, point.Y - 30, point.X + 4, point.Y - 30));
            addshape(new Line( point.X + 4, point.Y - 30, point.X + 4, point.Y));
            addshape(new Line( point.X + 2, point.Y - 30, point.X + 2, point.Y - 60));
            addshape(new Line( point.X + 2, point.Y - 30, point.X + 30, point.Y - 55));
            addshape(new Line(point.X + 2, point.Y - 30, point.X - 30, point.Y - 55));
            addshape(new Line(point.X + 2, point.Y - 30, point.X + 30, point.Y - 40));
            addshape(new Line(point.X + 2, point.Y - 30, point.X - 30, point.Y - 40));
        }
        /*public void Draw(Point point, Panel Drawingpanel)
        {
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, point.X, point.Y, point.X + 4, point.Y);
            g.DrawLine(p, point.X, point.Y, point.X , point.Y - 30);
            g.DrawLine(p, point.X , point.Y - 30, point.X + 4, point.Y-30);
            g.DrawLine(p, point.X + 4, point.Y - 30, point.X + 4, point.Y );
            g.DrawLine(p, point.X + 2, point.Y - 30, point.X + 2, point.Y - 60);
            g.DrawLine(p, point.X + 2, point.Y - 30, point.X + 30, point.Y - 55);
            g.DrawLine(p, point.X + 2, point.Y - 30, point.X - 30, point.Y - 55);
            g.DrawLine(p, point.X + 2, point.Y - 30, point.X + 30, point.Y - 40);
            g.DrawLine(p, point.X + 2, point.Y - 30, point.X - 30, point.Y - 40);
            //g.DrawLine(p, point.X, point.Y, point.X + 15, point.Y - 30);
        }*/
    }
}
