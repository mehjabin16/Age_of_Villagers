using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xunit;


namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        protected Panel Drawingpanel;
        public Color terraincolor;
        Point point;
        public object DrawHouse(Point point, Panel Drawingpanel)
        {
            BangladeshiHouse house = new BangladeshiHouse(point);
            house.Draw(point, Drawingpanel);
            return house;
        }
        public object TestHouse(Point point)
        {
            return new BangladeshiHouse(point);
        }

        public object DrawTree(Point point, Panel Drawingpanel)
        {
            BangladeshiTree tree = new BangladeshiTree(point);
            tree.Draw(point, Drawingpanel);
            return tree;
        }

        public object DrawWaterSource(Point point, Panel Drawingpanel)
        {
            BangladeshiWaterSource ws = new BangladeshiWaterSource(point);
            ws.Draw(point, Drawingpanel);
            return ws;
        }

        public Color PaintTerrain() 
        { 
        
            terraincolor = Color.LightGreen;
            return terraincolor;
            
        }
       
    }
}
