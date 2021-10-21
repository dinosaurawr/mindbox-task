using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;

namespace ShapesTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetArea_ValidRadius_GetRightArea()
        {
            const int radius = 2;
            var expectedArea = Math.PI * Math.Pow(radius, 2);

            var circle = new Circle(radius);
            var actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void GetArea_InvalidRadius_ThrowArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
        }
    }
}
