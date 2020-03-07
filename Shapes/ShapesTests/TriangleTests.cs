using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;

namespace ShapesTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetArea_ValidSides_ShoulReturnExpectedArea()
        {
            double firstSide = 4;
            double secondSide = 5;
            double thirdSide = 6;

            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
            double expectedArea = Math.Sqrt(
                halfPerimeter *
                (halfPerimeter - firstSide) *
                (halfPerimeter - secondSide) *
                (halfPerimeter - thirdSide));

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            double actualArea = triangle.GetArea();
            Console.WriteLine(expectedArea);
            Console.WriteLine(actualArea);


            Assert.AreEqual(actualArea, expectedArea);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetArea_InvalidArgument_ShouldThrowArgumentOutOfRangeException()
        {
            Triangle triangle = new Triangle(-2, 3, -13);
        }

        [TestMethod]
        public void IsTriangleExist_NotExistingTriangle_ShouldThrowTriangleDoesNotExistException()
        {
            Triangle triangle = new Triangle(1, 1, 1);
        }

        [TestMethod]
        public void IsTriangleRight_RightTriangle_IsTriangleRightShouldReturnTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsTriangleRight());
        }
    }
}
