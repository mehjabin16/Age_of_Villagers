using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NullNation : INation
    {   
        public Color terraincolor;
        public object DrawHouse(Point point, Panel Drawingpanel)
        {
            NullItem nullH = new NullItem();
            nullH.Draw(point, Drawingpanel);
            return nullH;
        }

        public object DrawTree(Point point, Panel Drawingpanel)
        {
            NullItem nullT = new NullItem();
            nullT.Draw(point, Drawingpanel);
            return nullT;
        }
        public object TestNullTree()
        {
            return new NullItem();
        }

        public object DrawWaterSource(Point point, Panel Drawingpanel)
        {
            NullItem nullW = new NullItem();
            nullW.Draw(point, Drawingpanel);
            return nullW;
        }

        public Color PaintTerrain()
        {
             terraincolor = Color.White;
            return terraincolor;
        }
    }
}
