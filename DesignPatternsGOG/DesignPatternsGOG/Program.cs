using DesignPatternsGOG.CreationalPatterns.AbstractFactory;
using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Base;
using System;

namespace DesignPatternsGOG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creational Patterns
            RunAbstractFactory();

            // Wait for user input
            Console.ReadKey();
        }

        /// <summary>
        /// The abstract factory pattern is used to provide a client with a set of related or dependant objects.
        /// The "family" of objects created by the factory are determined at run-time.
        /// </summary>
        static void RunAbstractFactory()
        {
            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();            
        }
    }
}
