using System;
using System.Collections.Generic;

namespace Ex06_PolymorphismWithCollections
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Dog barks");
    }

    class Cat : Animal
    {
        public override void MakeSound() => Console.WriteLine("Cat meows");
    }

    class Bird : Animal
    {
        public override void MakeSound() => Console.WriteLine("Bird chirps");
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Heterogeneous collection: list of base-class references.
            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Bird()
            };

            // Each element is treated as an Animal,
            // but the correct overridden method is called for each object.
            foreach (var a in animals)
            {
                a.MakeSound();
            }

            Console.ReadKey();
        }
    }
}

/*
LAB IDEA:
- Polymorphism + collections = powerful pattern:
  process different object types in one loop using the same method call.
*/
