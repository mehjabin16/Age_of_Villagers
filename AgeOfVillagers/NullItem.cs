using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NullItem : IShape
    {
        public void Draw(Point point, Panel Drawingpanel)
        {
            MessageBox.Show("No Item found");
        }
    }
}
