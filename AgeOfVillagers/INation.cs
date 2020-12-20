using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public interface INation
    {
        public object DrawHouse(Point point, Panel Drawingpanel);
        public object DrawTree(Point point, Panel Drawingpanel);
        public object DrawWaterSource(Point point, Panel Drawingpanel);
        public Color PaintTerrain();

    }
}
