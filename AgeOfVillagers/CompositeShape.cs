using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public abstract class CompositeShape : IShape
    {
        private List<IShape> items;
        //private Panel Drawingpanel;
        public CompositeShape()
        {
            items = new List<IShape>();
            
        }
        public void addshape(IShape shape)
        {
            items.Add(shape);
        }
        public void Draw(Point point, Panel Drawingpanel)
        {
            foreach(var item in items)
            {
                item.Draw(point, Drawingpanel);
            }
        }
    }
}
