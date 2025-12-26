using System;

namespace Ex05_MultipleDerivedClasses
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle starting...");
        }
    }

    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car engine started!");
        }
    }

    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike started with a kick!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Car();
            Vehicle v2 = new Bike();

            v1.Start();  // Car implementation
            v2.Start();  // Bike implementation

            Console.ReadKey();
        }
    }
}

/*
LAB MESSAGE:
- One common interface Start(), many concrete behaviors.
- Makes it easy to add new Vehicle types later (Truck, Bus...) without changing existing code.
*/
