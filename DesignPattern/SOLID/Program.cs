using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            SOLID stands for:
                S - Single - responsiblity Principle
                O - Open - closed Principle
                L - Liskov Substitution Principle
                I - Interface Segregation Principle
                D - Dependency Inversion Principle


            Single - responsibility Principle states:
               A class should have one and only one reason to change, meaning that a class should have only one job.

            Open-closed Principle states:
               Objects or entities should be open for extension but closed for modification.
               This means that a class should be extendable without modifying the class itself.

            Liskov Substitution Principle states:
               Let q(x) be a property provable about objects of x of type T. Then q(y) should be provable for objects y of type S where S is a subtype of T.
               This means that every subclass or derived class should be substitutable for their base or parent class.

            Interface segregation principle states:
               A client should never be forced to implement an interface that it doesn’t use, or clients shouldn’t be forced to depend on methods they do not use.
               Splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about the methods that are of interest to them

            Dependency inversion principle states:
              Entities must depend on abstractions, not on concretions. It states that the high-level module must not depend on the low-level module, but they should depend on abstractions.

            */

            Console.WriteLine("Hello World!");
        }
    }
}
