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
            double expectedArea = Math.PI * 144;
            Circle circle = new Circle(12);
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetArea_InvalidRadius_ThrowArgumentOutOfRangeException()
        {
            Circle circle = new Circle(-2);
        }
    }
}
