using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public struct VillageState  
    {
        public string villagename;
        public string nationname;
        public Color terraincolor;
        public List<Point> Houses;
        public List<Point> Trees;
        public List<Point> Watersources;


    }
}
