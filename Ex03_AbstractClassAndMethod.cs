using System;
// (Shape / Circle – polymorphic blueprint)
namespace Ex03_AbstractClassAndMethod
{
    // Abstract class: cannot be instantiated, only inherited.
    abstract class Shape
    {
        // Abstract method: no body here.
        // Each derived shape MUST provide its own implementation.
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double Radius;

        public Circle(double r)
        {
            Radius = r;
        }

        // Concrete implementation of the abstract method.
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Shape s = new Shape(); // ❌ not allowed (abstract)
            Shape circle = new Circle(3);

            Console.WriteLine("Circle area = " + circle.CalculateArea());

            Console.ReadKey();
        }
    }
}

/*
LAB IDEA:
- Abstract class defines "what must exist" (contract),
  derived classes define "how" (implementation).
- Forces polymorphic behavior: every Shape must implement CalculateArea().
*/
