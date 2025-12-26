using System;
// (Same Animal/ Dog/ Cat idea, focusing on the base reference)
namespace Ex04_DynamicBindingBaseReference
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
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

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
            Animal a;  // base class reference

            a = new Dog();
            a.MakeSound(); // "Dog barks"

            a = new Cat();
            a.MakeSound(); // "Cat meows"

            Console.ReadKey();
        }
    }
}

/*
KEY POINT:
- The variable type is Animal, but the executed method depends
  on the *actual* object stored in 'a'. This is dynamic binding.
*/
