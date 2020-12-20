using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class VillageStateSaver : IState
    {
        protected VillageState village;
        private Stream myStream;
        public VillageStateSaver(VillageState village)
        {
            this.village = village;
        }
        public void execute()
        {


            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.InitialDirectory = @"G:\3.1\DP\solutions\33-nafisa\AgeOfVillagers\savedfile";
            sfDialog.RestoreDirectory = true;
            sfDialog.FileName = "*.aov";
            sfDialog.DefaultExt = "aov";
            sfDialog.Filter = "AoV file(*.aov)| *.aov";

            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                Stream myStream;
                if ((myStream = sfDialog.OpenFile()) != null)
                {
                    using (StreamWriter sw = new StreamWriter(myStream))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(sw, village);
                        sw.Close();
                    }
                    myStream.Close();
                }
            }
        }
        
    }
}
