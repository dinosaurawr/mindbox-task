using Shapes.Exceptions;
using System;
using System.Linq;

namespace Shapes
{
    public class Triangle : Shape
    {
        public double Hypotenuse { get; set; }
        public double FirstCathetus { get; set; }
        public double Secondcathetus { get; set; }
        private readonly double halfPerimeter;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (!this.IsTriangleExist(firstSide, secondSide, thirdSide))
            {
                throw new TriangleDoesNotExistException();
            }
            double[] sides = { firstSide, secondSide, thirdSide };
            this.Hypotenuse = sides.Max();
            this.halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
            int hypotenuseInd = Array.IndexOf(sides, this.Hypotenuse);
            sides = sides.Where((val, ind) => ind != hypotenuseInd).ToArray();
            this.FirstCathetus = sides[0];
            this.Secondcathetus = sides[1];
        }


        private bool IsTriangleExist(double firstSide, double secondSide, double thirdSide)
        {
            if (
                firstSide + secondSide > thirdSide &&
                firstSide + thirdSide > secondSide &&
                secondSide + thirdSide > firstSide)
            {
                return true;
            }
            return false;
        }

        public bool IsTriangleRight()
        {
            return Math.Pow(this.Hypotenuse, 2) == Math.Pow(this.FirstCathetus, 2) + Math.Pow(this.Secondcathetus, 2);
        }

        public override double GetArea()
        {
            if (this.IsTriangleRight())
            {
                return (this.FirstCathetus * this.Secondcathetus) / 2;
            }
            else
            {
                return Math.Sqrt(
                    this.halfPerimeter *
                    (this.halfPerimeter - this.Hypotenuse) *
                    (this.halfPerimeter - this.FirstCathetus) *
                    (this.halfPerimeter - this.Secondcathetus));
            }
        }
    }
}
