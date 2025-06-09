using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RectangleAreact1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

namespace MathTaskClassLibraryTests
    {
        [TestClass]
        public class GeometryTests
        {
            [TestMethod]
            public void RectangleArea_3and5_15returned()
            {
                
                int a = 34;
                int b = 5;
                int expected = 15;

                Geometry g = new Geometry();
                int actual = g.RectangleArea(a, b);

                Assert.AreEqual(expected, actual);
            }
        }
    }

}
    }
}
