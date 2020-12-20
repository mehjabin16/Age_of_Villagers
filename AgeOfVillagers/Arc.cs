using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Arc : IShape
    {
        private float x1;
        private float y1;
        private float width;
        private float height;
        private float startAngle;
        private float sweepAngle;

        public Arc(float x1, float y1, float width, float height, float startAngle, float sweepAngle)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;

        }
        public void Draw(Point point, Panel Drawingpanel)
        {
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawArc(p, x1, y1, width, height, startAngle, sweepAngle);
            
        }
    }
}
