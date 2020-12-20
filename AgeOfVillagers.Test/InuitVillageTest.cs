using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class InuitVillageTest
    {
        Point point = new Point(10, 30);

        [Fact]
       
        public void InuitHouseTest()
        {
            InuitHouse ihousetest = new InuitHouse(point);
            InuitHunters inuit = new InuitHunters();
            object house = inuit.TestHouse(point);
            ihousetest.Equals(house);
        }
    }
}
