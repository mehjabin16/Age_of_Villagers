using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    
    public partial class DrawingWindow : Form
    {
        public static string VillageName;
        public string nation_name ;
        private VillageState village;
        private Nations nation;
        private List<Point> house_locations { get; set; } = new List<Point>();
        private List<Point> tree_locations { get; set; } = new List<Point>();
        private List<Point> watersource_locations { get; set; } = new List<Point>();
        public DrawingWindow()
        {
            InitializeComponent();
            village = new VillageState();
           

        }
        private void DrawingWindow_Load(object sender, EventArgs e)
        {
            nation_name = Form1.NationName;
            label2.Text = Form1.VillageName;
            label3.Text = nation_name;
            Nations nation = new Nations(nation_name, Drawingpanel);
            nation.getNation().PaintTerrain(Drawingpanel);
            
             if (nation_name == "Arab Beduins")
            {
                
                radioButton3.Visible = false;
            }
            
             if (nation_name == "Inuit Hunters")
            {
                radioButton3.Visible = false;
                radioButton1.Visible = false;
            }
            

        }
        public void GetVillageState()
        {   

            village.villagename = label2.Text;
            village.nationname = Form1.NationName;
            village.terraincolor = Drawingpanel.BackColor;
            village.Houses = house_locations;
            village.Trees =  tree_locations;
            village.Watersources = watersource_locations;
        }
        public void SetVillageState(VillageState village)
        {
            Drawingpanel.BackColor = village.terraincolor;
            label2.Text = village.villagename;
            label3.Text = village.nationname;
            if (village.nationname == "Bangladeshi Farmers")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
            }
            else if (village.nationname == "Arab Beduins")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = false;
            }

            else if (village.nationname == "Inuit Hunters")
            {
                radioButton2.Visible = true;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
            }
            else if (village.nationname == "Egyptian Kings")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
            }


            house_locations.Clear();
            tree_locations.Clear();
            watersource_locations.Clear();

            foreach (Point point in village.Houses)
            {
                house_locations.Add(point);
            }
            foreach (Point point in village.Trees)
            {
                house_locations.Add(point);
            }
            foreach (Point point in village.Watersources)
            {
                watersource_locations.Add(point);
            }
            
        }


        private void SaveVillage_Click(object sender, EventArgs e)
        {

            GetVillageState();
            VillageStateSaver savevillage = new VillageStateSaver(village);
            savevillage.execute();


        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            Refresh();

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
           
            VillageStateLoader load = new VillageStateLoader();

            load.execute();
            village = load.LoadVillage();
            SetVillageState(village);
            Repaint(village);
            

        }
        private void Drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            nation_name = Form1.NationName;
            Point P = new Point(e.X, e.Y);
            Nations nation = new Nations(nation_name, Drawingpanel);

            if (radioButton2.Checked == true)
            {
                nation.getNation().DrawHouse(P, Drawingpanel);
                //state.setHouseState(P);
                house_locations.Add(P);

            }
            if (radioButton1.Checked == true)
            {

                nation.getNation().DrawTree(P, Drawingpanel);
                //state.setTreeState(P);
                tree_locations.Add(P);

            }
            if (radioButton3.Checked == true)
            {

                nation.getNation().DrawWaterSource(P, Drawingpanel);
                //state.setWsourceState(P);
                watersource_locations.Add(P);
            }
            //Drawingpanel.Invalidate();
        }

        private void Repaint(VillageState village)
        {
            // repaint //
            //nation_name = village.nationname;
            Drawingpanel.Refresh();
            
            Nations nation = new Nations(village.nationname, Drawingpanel);
            if (house_locations != null)
            {
                foreach (Point point in house_locations)
                {
                    nation.getNation().DrawHouse(point, Drawingpanel);
                }
            }
            if (tree_locations != null)
            {
                foreach (Point point in tree_locations)
                {
                    nation.getNation().DrawTree(point, Drawingpanel);
                }
            }
            if (tree_locations != null)
            {
                foreach (Point point in watersource_locations)
                {
                    nation.getNation().DrawWaterSource(point, Drawingpanel);
                }
            }
        }
    }
}
