using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AgeOfVillagers
{
    
    public partial class DrawingWindow : Form
    {
        public static string VillageName;
        public static string nation_name; 
        private VillageState village;
        public Color TerrainColor;
        //private Nations nation;
        public Boolean openbuttonclicked;
        public Boolean nationchanged;
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
           
            villagebox.Text = Form1.VillageName;
            visible_radiobutton(nation_name);
            
           

        }
        private void visible_radiobutton(string nation_name)
        {   
            if (nation_name == "Bangladeshi Farmers")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
            }
            else if (nation_name == "Arab Beduins")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = false;
            }

            else if (nation_name == "Inuit Hunters")
            {
                radioButton2.Visible = true;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
            }
            else if (nation_name == "Egyptian Kings")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
            }

        }
        public void GetVillageState()
        {   

            village.villagename = villagebox.Text;
            village.nationname = changeNation.Text;
            village.terraincolor = Drawingpanel.BackColor;
            village.Houses = house_locations;
            village.Trees =  tree_locations;
            village.Watersources = watersource_locations;
        }
        public void SetVillageState(VillageState village)
        {
            Drawingpanel.BackColor = village.terraincolor;
            villagebox.Text = village.villagename;
            nation_name = village.nationname;
            nationlabel.Text = nation_name;

            if ( nation_name == "Bangladeshi Farmers") { 
            changeNation.SelectedIndex = 0;
            }
            else if (nation_name == "Arab Beduins")
            {
            changeNation.SelectedIndex = 1;
            }
            else if (nation_name == "Egyptian Kings")
            {
                changeNation.SelectedIndex = 2;
            }
            else if (nation_name == "Inuit Hunters")
            {
                changeNation.SelectedIndex = 3;
            }


            visible_radiobutton(nation_name);
            
            house_locations.Clear();
            tree_locations.Clear();
            watersource_locations.Clear();

            foreach (Point point in village.Houses)
            {
                house_locations.Add(point);
            }
            foreach (Point point in village.Trees)
            {
                tree_locations.Add(point);
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
            villagebox.Clear();
            house_locations.Clear();
            tree_locations.Clear();
            watersource_locations.Clear();
            changeNation.ResetText();
            Drawingpanel.Refresh();
            Drawingpanel.BackColor = Color.White;
           // Refresh();

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            openbuttonclicked = true;
            VillageStateLoader load = new VillageStateLoader();

            load.execute();
            village = load.LoadVillage();
            SetVillageState(village);
            Repaint(village);
            

        }
        private void Drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {

            if (openbuttonclicked == true)
            {
                nation_name = village.nationname;
            }
            if (nationchanged == true)
            {
                nation_name = changeNation.Text;
            }
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
            nation_name = changeNation.Text;
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
            if (watersource_locations != null)
            {
                foreach (Point point in watersource_locations)
                {
                    nation.getNation().DrawWaterSource(point, Drawingpanel);
                }
            }
        }

        private void changeNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            nationchanged = true;
            nation_name = changeNation.Text;
            nationlabel.Text = nation_name;
            visible_radiobutton(nation_name);
            Nations nation = new Nations(nation_name, Drawingpanel);
            TerrainColor = nation.getNation().PaintTerrain();
            Drawingpanel.BackColor = TerrainColor;

           // house_locations.Clear();
           // tree_locations.Clear();
           // watersource_locations.Clear();


        }
        private void villagebox_TextChanged(object sender, EventArgs e)
        {
            VillageName = villagebox.Text;
        }
    }
}
