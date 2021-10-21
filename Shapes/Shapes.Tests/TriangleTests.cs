using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using Shapes.Exceptions;
using System;

namespace ShapesTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetArea_ValidSides_ShouldReturnExpectedArea()
        {
            const double firstSide = 4;
            const double secondSide = 5;
            const double thirdSide = 6;

            var halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
            var expectedArea = Math.Sqrt(
                halfPerimeter *
                (halfPerimeter - firstSide) *
                (halfPerimeter - secondSide) *
                (halfPerimeter - thirdSide));

            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var actualArea = triangle.GetArea();

            Assert.AreEqual(actualArea, expectedArea);
        }

        [TestMethod]
        public void GetArea_InvalidArgument_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-2, 3, 13));
        }

        [TestMethod]
        public void IsTriangleExist_NotExistingTriangle_ShouldThrowTriangleDoesNotExistException()
        {
            Assert.ThrowsException<TriangleDoesNotExistException>(() => new Triangle(1, 1, 2));
        }

        [TestMethod]
        public void IsTriangleRight_RightTriangle_IsTriangleRightTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsTriangleRight());
        }
    }
}
