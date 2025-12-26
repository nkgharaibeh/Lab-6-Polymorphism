using System;

namespace Ex01_VirtualOverrideBasics
{
    // Base class
    class Animal
    {
        // 'virtual' means: this method can be overridden in derived classes.
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived class Dog overrides MakeSound()
    class Dog : Animal
    {
        // 'override' replaces the base implementation with a specialized one.
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Derived class Cat overrides MakeSound()
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // IMPORTANT POLYMORPHISM IDEA:
            // Base-class reference, but actual object is Dog or Cat.
            Animal a1 = new Dog(); // runtime type: Dog
            Animal a2 = new Cat(); // runtime type: Cat

            // The overridden method that executes depends on the *actual* object type,
            // not on the variable type => runtime polymorphism (dynamic dispatch).
            a1.MakeSound(); // "Dog barks"
            a2.MakeSound(); // "Cat meows"

            Console.ReadKey();
        }
    }
}

/*
SLIDE / LAB MESSAGE:
- Same method name (MakeSound), different behaviors in Dog and Cat.
- This is core OOP polymorphism: "many forms" of the same operation.
*/
