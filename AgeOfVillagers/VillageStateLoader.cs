using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class VillageStateLoader : IState
    {
        public VillageState village;
        public void execute()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = ofd.OpenFile();
                using (StreamReader streamReader = new StreamReader(myStream))
                {
                    string json = streamReader.ReadToEnd();
                    village = JsonConvert.DeserializeObject<VillageState>(json);
                }
            }
        }
        public VillageState LoadVillage()
        {
            return village;
        }
    }
}
