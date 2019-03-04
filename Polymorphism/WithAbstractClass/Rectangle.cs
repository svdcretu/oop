using System;

namespace Polymorphism.WithAbstractClass
{
    public class Rectangle: AbstractGeometricalObject
    {
        private readonly double _x;
        private readonly double _y;

        public Rectangle(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public override double CalculateArea()
        {
            string s = DetailedDescription();

            Console.WriteLine($"Calculate area for {s}");
            return _x * _y;
        }

        public override double CalculatePerimeter()
        {
            string s = BasicDescription();

            Console.WriteLine($"Calculate perimeter for {s}");
            return 2 * (_x + _y);
        }

        public override string DetailedDescription()
        {
            string desription = $"Rectangle Detailed Description with x = {_x} and y = {_y}";

            return desription;
        }

        public new string BasicDescription()
        {
            string description = "Rectangle basic description";

            return description;
        }
    }
}
