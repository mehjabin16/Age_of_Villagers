using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class NullNationTest
    {
        Point point = new Point(10, 20);

        [Fact]
        public void TerrainColorTest()
        {
            NullNation Nullcolor = new NullNation();
            Color actual = Nullcolor.PaintTerrain();
            Color expected = Color.White;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void NullItemTest()
        {
            NullNation nullItem = new NullNation();
            Object actual = nullItem.TestNullTree();
            Object expected = new NullItem();
            actual.Equals(expected);
        }
    }
}
