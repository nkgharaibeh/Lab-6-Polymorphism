using System;
using System.Collections.Generic;

namespace CaseStudy1_ShapeAreaCalculator
{
    // Abstract base class defines the common interface.
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double Radius;

        public Circle(double r)
        {
            Radius = r;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width, Height;

        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // List of Shape references: Circle and Rectangle objects live together.
            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),       // radius = 5
                new Rectangle(8, 5)  // 8 x 5
            };

            foreach (Shape s in shapes)
            {
                // Runtime polymorphism: the correct CalculateArea()
                // is chosen based on the actual shape type.
                Console.WriteLine("Area: " + s.CalculateArea());
            }

            Console.ReadKey();
        }
    }
}

/*
EXPLANATION (كما في اللاب):
- Same interface (CalculateArea) with different implementations.
- Demonstrates clean and extensible design: add new shapes without
  changing the code that uses the Shape list.
*/
