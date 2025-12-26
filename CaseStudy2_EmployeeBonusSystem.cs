using System;

namespace CaseStudy2_EmployeeBonusSystem
{
    class Employee
    {
        public string Name;
        public double Salary;

        // Default implementation (not really used in this scenario,
        // but shows that base class can provide a general rule).
        public virtual double CalculateBonus()
        {
            return Salary * 0.05; // 5% as a generic default
        }
    }

    class Manager : Employee
    {
        public override double CalculateBonus()
        {
            // Managers get 20% bonus
            return Salary * 0.2;
        }
    }

    class Developer : Employee
    {
        public override double CalculateBonus()
        {
            // Developers get 10% bonus
            return Salary * 0.1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Notice: we store Manager and Developer in Employee references
            // (base type) to emphasize polymorphism.
            Employee e1 = new Manager { Name = "Huda", Salary = 1000 };
            Employee e2 = new Developer { Name = "Sami", Salary = 1000 };

            Console.WriteLine("Manager: " + e1.Name + ", Bonus: " + e1.CalculateBonus());
            Console.WriteLine("Developer: " + e2.Name + ", Bonus: " + e2.CalculateBonus());

            Console.ReadKey();
        }
    }
}

/*
LAB EXPLANATION:
- Shows how overriding lets each employee type have its own formula.
- Easy to add new employee roles later (Tester, Designer...) just by
  adding new subclasses with different CalculateBonus() logic.
*/
