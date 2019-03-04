namespace Polymorphism.WithAbstractClass
{
    public abstract class AbstractGeometricalObject : IGeometricalObject
    {
        public string BasicDescription()
        {
            string description = "Basic Description of abstract geometrical object";

            return description;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public virtual string DetailedDescription()
        {
            string description = "VIRTUAL Detailed Description of abstract geometrical object";

            return description;
        }
    }
}
