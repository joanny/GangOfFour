using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype p1 = new ConcretePrototype("I");
            ConcretePrototype c1 = (ConcretePrototype)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype1 p2 = new ConcretePrototype1("II");
            ConcretePrototype1 c2 = (ConcretePrototype1)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);

            // Wait for user
            Console.ReadKey();
        }
    }
}
