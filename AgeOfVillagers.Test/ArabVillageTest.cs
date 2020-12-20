using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class ArabVillageTest
    {
        Point point = new Point(10, 30);

        [Fact]
        public void ArabTreeTest()
        {
            ArabTree treetest = new ArabTree(point);
            ArabBeduins ab = new ArabBeduins();
            object tree = ab.TestTree(point);
            treetest.Equals(tree);
        }
    }
}
