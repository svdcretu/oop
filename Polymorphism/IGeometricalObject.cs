using System;

namespace Polymorphism
{
    public interface IGeometricalObject
    {
        double CalculateArea();

        double CalculatePerimeter();

        string BasicDescription();

        string DetailedDescription();
    }
}
