using System;

using Polymorphism;

namespace OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            var abstractExample = new Client();

            abstractExample.DisplayIndividualGeometricalFigures();

            Console.ReadLine();

            abstractExample.DisplayGeometricalFiguresWithAbstractClass();


        }
    }
}
