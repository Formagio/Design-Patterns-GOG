using System;
using AbstractFactory = DesignPatternsGOG.CreationalPatterns.AbstractFactory;
using Builder = DesignPatternsGOG.CreationalPatterns.Builder;

namespace DesignPatternsGOG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creational Patterns
            Console.WriteLine("Abstract Factory...");
            RunAbstractFactory();

            Console.WriteLine("\nBuilder...");
            RunBuilder();

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
            var factory1 = new AbstractFactory.ConcreteFactory1();
            var client1 = new AbstractFactory.Client(factory1);
            client1.Run();

            // Abstract factory #2
            var factory2 = new AbstractFactory.ConcreteFactory2();
            var client2 = new AbstractFactory.Client(factory2);
            client2.Run();            
        }

        /// <summary>
        /// The builder pattern is used to create complex objects with constituent parts that must be created 
        /// in the same order or using a specific algorithm. An external class controls the construction algorithm.
        /// </summary>
        static void RunBuilder()
        {
            // Create director and builders
            var director = new Builder.Director();
            var b1 = new Builder.ConcreteBuilder1();
            var b2 = new Builder.ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            var p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            var p2 = b2.GetResult();
            p2.Show();
        }
    }
}
