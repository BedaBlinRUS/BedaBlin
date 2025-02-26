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
                // Исходные данные
                int a = 34;
                int b = 5;
                int expected = 15;

                // Получение значения с помощью тестируемого метода
                Geometry g = new Geometry();
                int actual = g.RectangleArea(a, b);

                // Сравнение ожидаемого результата с полученным
                Assert.AreEqual(expected, actual);
            }
        }
    }

}
    }
}
