using System;
// (Call parent behavior, then extend it in the child)
namespace Ex02_BaseKeywordUsage
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Bird : Animal
    {
        public override void Eat()
        {
            // 'base.Eat()' calls the original method in the parent class first.
            base.Eat();

            // Then we extend the behavior with extra lines:
            Console.WriteLine("Bird pecks seeds");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Bird();

            // Even though 'a' is typed as Animal,
            // the overridden Bird.Eat() is executed (polymorphism).
            a.Eat();

            Console.ReadKey();
        }
    }
}

/*
LAB EXPLANATION:
- base.Eat() lets you reuse the parent implementation and then add more behavior.
- This is common in real systems: child class extends, not completely replaces, parent logic.

SLIDE POINTS:
- 'base' keyword is used inside a derived class to call:
    - base class methods
    - base class constructors
- Typical pattern: "extend, don't replace" parent behavior.
*/
