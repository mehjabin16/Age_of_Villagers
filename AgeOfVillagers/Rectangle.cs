using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class Rectangle: CompositeShape
    {
        private int topl_x;
        private int topl_y;
        private int topr_x;
        private int topr_y;
        private int bottoml_x;
        private int bottoml_y;
        private int bottomr_x;
        private int bottomr_y;
        public Rectangle(int topl_x, int topl_y, int topr_x, int topr_y, int bottoml_x, int bottoml_y,  int bottomr_x, int bottomr_y)
        {
            this.topl_x = topl_x;
            this.topl_y = topl_y;
            this.topr_x = topr_x;
            this.topr_y = topr_y;
            this.bottoml_x = bottoml_x;
            this.bottoml_y = bottoml_y;
            this.bottomr_x = bottomr_x;
            this.bottomr_y = bottomr_y;

            addshape(new Line(topl_x, topl_y,  topr_x, topr_y));
            addshape(new Line(topl_x, topl_y, bottoml_x, bottoml_y));
            addshape(new Line(topr_x, topr_y, bottomr_x, bottomr_y));
            addshape(new Line(bottoml_x, bottoml_y, bottomr_x, bottomr_y));

        }
    }
}
