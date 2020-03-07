using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            if (radius > 0)
            {
                this.Radius = radius;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
