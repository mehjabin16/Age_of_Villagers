using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AgeOfVillagers;
using Xunit;



namespace AgeOfVillagers.Test
{
   
    public class TerrainColorTest
    {

        [Fact]
        public void BangladeshiFarmerTest()
        {
            BangladeshiFarmers bdTerrainColor = new BangladeshiFarmers();
            Color expected = bdTerrainColor.PaintTerrain();
            Color actual = Color.LightGreen;
            Xunit.Assert.Equal(actual, expected);
        }

        [Fact]
        public void ArabBeduinTest()
        {
            ArabBeduins abTerrainColor = new ArabBeduins();
            Color expected = abTerrainColor.PaintTerrain();
            Color actual = Color.LightGoldenrodYellow;
            Xunit.Assert.Equal(actual, expected);
        }

        [Fact]
        public void EgyptianKingTest()
        {
            EgyptianKings egTerrainColor = new EgyptianKings();
            Color expected = egTerrainColor.PaintTerrain();
            Color actual = Color.Yellow;
            Xunit.Assert.Equal(actual, expected);
        }
        [Fact]
        public void InuitHunter()
        {
            InuitHunters ihTerrainColor = new InuitHunters();
            Color expected = ihTerrainColor.PaintTerrain();
            Color actual = Color.White;
            Xunit.Assert.Equal(actual, expected);
        }



    }
}
