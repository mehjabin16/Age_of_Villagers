using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AgeOfVillagers;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class BDVillageTest
    {
        Point point = new Point(10, 30);

        [Fact]
        public void BangladeshiHouseTest()
        {
            BangladeshiHouse bdhousetest = new BangladeshiHouse(point);
            BangladeshiFarmers bd = new BangladeshiFarmers();
            object house = bd.TestHouse(point);
            bdhousetest.Equals(house);
        }
    }
}
