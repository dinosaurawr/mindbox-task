using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private readonly double radius;
        public Circle(double radius)
        {
            if (radius > 0) this.radius = radius;
            else throw new ArgumentException(nameof(radius));
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
