using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class Ellipse: CompositeShape
    {
        private float x1;
        private float y1;
        private float width;
        private float height;
        float startAngle = 45;
        float sweepAngle = 360;

        public Ellipse(float x1, float y1, float width, float height)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.height = height;
            addshape(new Arc(x1, y1, width, height, startAngle, sweepAngle));

        }
    }
}
