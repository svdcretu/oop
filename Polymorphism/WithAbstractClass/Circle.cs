using System;

namespace Polymorphism.WithAbstractClass
{
    public class Circle : AbstractGeometricalObject
    {
        private readonly double _r;
        private const double _pi = 3.14;

        public Circle(double r)
        {
            _r = r;
        }

        public override double CalculateArea()
        {
            string s = DetailedDescription();

            Console.WriteLine($"Calculate area for {s}");
            return (_r * _r * _pi);
        }

        public override double CalculatePerimeter()
        {
            string s = BasicDescription();

            Console.WriteLine($"Calculate perimeter for {s}");
            return 2 * _pi * _r;
        }

        public override string DetailedDescription()
        {
            string desription = $"Circle Detailed Description with r = {_r}";

            return desription;
        }

        public new string BasicDescription()
        {
            string description = "Circle basic description";

            return description;
        }
    }
}
