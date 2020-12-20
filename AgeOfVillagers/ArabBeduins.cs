using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ArabBeduins : INation
    {
       // private Panel Drawingpanel;
        public Color terraincolor;

        public object DrawHouse(Point point, Panel Drawingpanel)
        {
            ArabHouse abhouse = new ArabHouse(point);
            abhouse.Draw(point, Drawingpanel);
            return abhouse;
        }

        public object DrawTree(Point point, Panel Drawingpanel)
        {
            ArabTree abtree = new ArabTree(point);
            abtree.Draw(point, Drawingpanel);
            return abtree;
        }
        public object TestTree(Point point)
        {
            return new ArabTree(point);
        }

    
        public object DrawWaterSource(Point point, Panel Drawingpanel)
        {
            NullItem nullWsource = new NullItem();
            nullWsource.Draw(point, Drawingpanel);
            return nullWsource;
        }

        public Color PaintTerrain()
        {
            terraincolor = Color.LightGoldenrodYellow;
            return terraincolor;
        }
        
    }
}
