using System;

namespace Ex07_SealedMethod
{
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Base display");
        }
    }

    class DerivedClass : BaseClass
    {
        // 'sealed override' means:
        //  - we override the base method here,
        //  - and we STOP further overriding in subclasses.
        public sealed override void Display()
        {
            Console.WriteLine("Derived display");
        }
    }

    class SubDerivedClass : DerivedClass
    {
        // public override void Display() { } 
        // ❌ Not allowed: Display() is sealed in DerivedClass.
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass();
            DerivedClass d = new DerivedClass();
            SubDerivedClass s = new SubDerivedClass();

            b.Display(); // Base display
            d.Display(); // Derived display
            s.Display(); // Inherits Derived display, cannot change it

            Console.ReadKey();
        }
    }
}

/*
LAB MESSAGE:
- Sealed methods are used when the framework designer wants to allow
  ONE override level, but prevent further changes (for safety or design reasons).
*/
