using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Nations
    {
        private string Nationtype;
        private Panel Drawingpanel;
        public INation nation;


        public Nations(string Nationtype, Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
            this.Nationtype = Nationtype;

            if (Nationtype == "Bangladeshi Farmers")
            {
                
                nation = new BangladeshiFarmers();
            }
            else if (Nationtype == "Arab Beduins")
            {
               
                nation = new ArabBeduins();
            }
            else if (Nationtype == "Egyptian Kings")
            {
               
                nation = new EgyptianKings();
            }
            else if (Nationtype == "Inuit Hunters")
            {
                
                nation = new InuitHunters();
            }
            else 
            {
                nation = new NullNation();
            }
        }
        public INation getNation()
        {
            return nation;
        }

    }
}
