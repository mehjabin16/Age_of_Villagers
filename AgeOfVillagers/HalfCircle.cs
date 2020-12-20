using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class HalfCircle: CompositeShape
    {
        private float x1;
        private float y1;
        private float radius;
        float startAngle = 0;
        float sweepAngle = -180;

        public HalfCircle(float x1, float y1, float radius)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.radius = radius;
            addshape(new Arc(x1, y1, radius, radius, startAngle, sweepAngle));

        }
    }
}
