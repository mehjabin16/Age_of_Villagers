using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class InuitHunters : INation
    {
        //private Panel Drawingpanel;
        public Color terraincolor;
       
        public object DrawHouse(Point point, Panel Drawingpanel)
        {
            InuitHouse ihouse = new InuitHouse(point);
            ihouse.Draw(point, Drawingpanel);
            return ihouse;
        }
        public object TestHouse(Point point)
        {
            return new InuitHouse(point);
        }

        public object DrawTree(Point point, Panel Drawingpanel)
        {
            NullItem nullTree = new NullItem();
            nullTree.Draw(point, Drawingpanel);
            return nullTree;
        }


        public object DrawWaterSource(Point point, Panel Drawingpanel)
        {
            NullItem nullWsource = new NullItem();
            nullWsource.Draw(point, Drawingpanel);
            return nullWsource;
        }

        public Color PaintTerrain()
        {
            terraincolor = Color.White;
            return terraincolor;
        }
    }
}
