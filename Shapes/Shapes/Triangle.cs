using Shapes.Exceptions;
using System;
using System.Linq;

namespace Shapes
{
    public class Triangle : Shape
    {
        private readonly double hypotenuse;
        private readonly double firstCathetus;
        private readonly double secondCathetus;
        private readonly double halfPerimeter;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0) throw new ArgumentException(nameof(firstSide));
            if (secondSide < 0) throw new ArgumentException(nameof(secondSide));
            if (thirdSide < 0) throw new ArgumentException(nameof(thirdSide));

            if (!IsTriangleExist(firstSide, secondSide, thirdSide)) throw new TriangleDoesNotExistException();

            var sides = new[] { firstSide, secondSide, thirdSide };
            hypotenuse = sides.Max();

            var hypotenuseInd = Array.IndexOf(sides, hypotenuse);
            var catets = sides.Where((_, ind) => ind != hypotenuseInd).ToArray();
            firstCathetus = catets[0];
            secondCathetus = catets[1];

            halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
        }


        private bool IsTriangleExist(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide + secondSide > thirdSide &&
                   firstSide + thirdSide > secondSide &&
                   secondSide + thirdSide > firstSide;
        }

        public bool IsTriangleRight()
        {
            return Math.Pow(hypotenuse, 2) == Math.Pow(firstCathetus, 2) + Math.Pow(secondCathetus, 2);
        }

        public override double GetArea()
        {
            if (IsTriangleRight())
                return (firstCathetus * secondCathetus) / 2;
            return Math.Sqrt(
                halfPerimeter *
                (halfPerimeter - hypotenuse) *
                (halfPerimeter - firstCathetus) *
                (halfPerimeter - secondCathetus));
        }
    }
}
