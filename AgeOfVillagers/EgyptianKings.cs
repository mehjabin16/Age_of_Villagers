using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKings : INation
    {
        //private Panel Drawingpanel;
        private Color terraincolor;
      
        public object DrawHouse(Point point, Panel Drawingpanel)
        {
            EgyptianHouse ehouse = new EgyptianHouse(point);
            ehouse.Draw(point, Drawingpanel);
            return ehouse;
        }

        public object DrawTree(Point point, Panel Drawingpanel)
        {
            EgyptianTree etree = new EgyptianTree(point);
            etree.Draw(point, Drawingpanel);
            return etree;
        }

        public object DrawWaterSource(Point point, Panel Drawingpanel)
        {
            EgyptianWatersource ewatersource = new EgyptianWatersource(point);
            ewatersource.Draw(point, Drawingpanel);
            return ewatersource;
        }

        public Color PaintTerrain()
        {
            terraincolor = Color.Yellow;
            return terraincolor;
        }
    }

   
}
