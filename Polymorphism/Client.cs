using System;
using System.Collections.Generic;
using Polymorphism.WithAbstractClass;

namespace Polymorphism
{
    public class Client
    {

        public void DisplayIndividualGeometricalFigures()
        {
            IGeometricalObject geometricalObject = new Circle(100);
            Console.WriteLine("*************** IGeometricalObject geometricalObject = new Circle(100) ****************************");

            Console.WriteLine($"******** {geometricalObject.DetailedDescription()} ***********");
            geometricalObject.CalculatePerimeter();
            geometricalObject.CalculateArea();
            Console.WriteLine($"******** {geometricalObject.BasicDescription()} ***********");

            Console.WriteLine("******************************* END **************************************");
            Console.WriteLine();

            Console.WriteLine("*************** AbstractGeometricalObject ago = new Rectangle(100,150); ****************************");
            AbstractGeometricalObject ago = new Rectangle(100,150);
            Console.WriteLine($"******** {ago.DetailedDescription()} ***********");
            ago.CalculatePerimeter();
            ago.CalculateArea();
            Console.WriteLine($"******** {ago.BasicDescription()} ***********");

            Console.WriteLine("******************************* END **************************************");
            Console.WriteLine();

            Console.WriteLine("*************** Circle c = (Circle)geometricalObject; ****************************");
            Circle c = (Circle)geometricalObject;
            Console.WriteLine($"******** {c.DetailedDescription()} ***********");
            c.CalculatePerimeter();
            c.CalculateArea();
            Console.WriteLine($"******** {c.BasicDescription()} ***********");

            Console.WriteLine("******************************* END **************************************");
            Console.WriteLine();

            Console.WriteLine("*************** Rectangle r = new Rectangle(50,60); ****************************");
            Rectangle r = new Rectangle(50,60);
            Console.WriteLine($"******** {r.DetailedDescription()} ***********");
            r.CalculatePerimeter();
            r.CalculateArea();
            Console.WriteLine($"******** {r.BasicDescription()} ***********");

            Console.WriteLine("******************************* END **************************************");
            Console.WriteLine();
        }

        public void DisplayGeometricalFiguresWithAbstractClass()
        {
            var objects = new List<IGeometricalObject>();

            var abstractsObjects = new List<AbstractGeometricalObject>();

            IGeometricalObject rectangle1 = new Rectangle(10, 20);
            AbstractGeometricalObject rectangle2 = new Rectangle(20, 30);
            Rectangle rectangle3 = new Rectangle(30, 40);

            objects.Add(rectangle1);
            objects.Add(rectangle2);
            objects.Add(rectangle3);

            abstractsObjects.Add(rectangle2);
            abstractsObjects.Add(rectangle3);

            IGeometricalObject circle1 = new Circle(10);
            AbstractGeometricalObject circle2 = new Circle(20);
            Circle circle3 = new Circle(30);

            objects.Add(circle1);
            objects.Add(circle2);
            objects.Add(circle3);

            abstractsObjects.Add(circle2);
            abstractsObjects.Add(circle3);

            DisplayData(objects);
            DisplayAbstractData(abstractsObjects);


            Console.WriteLine($"******** {circle3.DetailedDescription()} ***********");
            circle3.CalculatePerimeter();
            circle3.CalculateArea();
            Console.WriteLine($"******** {circle3.BasicDescription()} ***********");

            Console.ReadLine();
        }

        private void DisplayData(List<IGeometricalObject> objects)
        {
            Console.WriteLine("***************** Display a List<IGeometricalObject> objects ******************");
            foreach (IGeometricalObject geometricalObject in objects)
            {
                
                Console.WriteLine($"******** {geometricalObject.DetailedDescription()} ***********");
                geometricalObject.CalculatePerimeter();
                geometricalObject.CalculateArea();
                Console.WriteLine($"******** {geometricalObject.BasicDescription()} ***********");
            }

            Console.WriteLine("*********************** END ************************************");
            Console.WriteLine();
        }

        private void DisplayAbstractData(List<AbstractGeometricalObject> objects)
        {
            Console.WriteLine("***************** Display a List<AbstractGeometricalObject> objects ******************");
            foreach (IGeometricalObject geometricalObject in objects)
            {

                Console.WriteLine($"******** {geometricalObject.DetailedDescription()} ***********");
                geometricalObject.CalculatePerimeter();
                geometricalObject.CalculateArea();
                Console.WriteLine($"******** {geometricalObject.BasicDescription()} ***********");
            }

            Console.WriteLine("*********************** END ************************************");
            Console.WriteLine();
        }
    }
}
