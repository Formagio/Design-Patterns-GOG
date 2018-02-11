using System;
using AbstractFactory = DesignPatternsGOG.CreationalPatterns.AbstractFactory;
using Adapter = DesignPatternsGOG.StructuralPatterns.Adapter;
using Bridge = DesignPatternsGOG.StructuralPatterns.Bridge;
using Builder = DesignPatternsGOG.CreationalPatterns.Builder;
using FactoryMethod = DesignPatternsGOG.CreationalPatterns.FactoryMethod;
using Prototype = DesignPatternsGOG.CreationalPatterns.Prototype;
using Singleton = DesignPatternsGOG.CreationalPatterns.Singleton;

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

            Console.WriteLine("\nFactory Method...");
            RunFactoryMethod();

            Console.WriteLine("\nPrototype...");
            RunPrototype();

            Console.WriteLine("\nSingleton...");
            RunSingleton();

            // Structural Patterns
            Console.WriteLine("\nAdapter...");
            RunAdapter();

            Console.WriteLine("\nBridge...");
            RunBridge();

            // Wait for user input
            Console.ReadKey();
        }

        /// <summary>
        /// The abstract factory pattern is used to provide a client with a set of related or dependant objects.
        /// The "family" of objects created by the factory are determined at run-time.
        /// </summary>
        static void RunAbstractFactory()
        {
            // Create and run the African animal world
            var africa = new AbstractFactory.AfricaFactory();
            var world = new AbstractFactory.AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            var america = new AbstractFactory.AmericaFactory();
            world = new AbstractFactory.AnimalWorld(america);
            world.RunFoodChain();            
        }

        /// <summary>
        /// The builder pattern is used to create complex objects with constituent parts that must be created 
        /// in the same order or using a specific algorithm. An external class controls the construction algorithm.
        /// </summary>
        static void RunBuilder()
        {
            Builder.Base.VehicleBuilder builder;

            // Create shop with vehicle builders
            Builder.Shop shop = new Builder.Shop();

            // Construct and display vehicles
            builder = new Builder.ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new Builder.CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new Builder.MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }

        /// <summary>
        /// The factory pattern is used to replace class constructors, abstracting the process of object generation 
        /// so that the type of the object instantiated can be determined at run-time.
        /// </summary>
        static void RunFactoryMethod()
        {
            // Note: constructors call Factory Method
            var documents = new FactoryMethod.Base.Document[2];

            documents[0] = new FactoryMethod.Resume();
            documents[1] = new FactoryMethod.Report();

            // Display document pages
            foreach (var document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }

        /// <summary>
        /// The prototype pattern is used to instantiate a new object by copying all of the properties of an 
        /// existing object, creating an independent clone. This practise is particularly useful when the construction 
        /// of a new object is inefficient.
        /// </summary>
        static void RunPrototype()
        {
            var colormanager = new Prototype.ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Prototype.Product.Color(255, 0, 0);
            colormanager["green"] = new Prototype.Product.Color(0, 255, 0);
            colormanager["blue"] = new Prototype.Product.Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Prototype.Product.Color(255, 54, 0);
            colormanager["peace"] = new Prototype.Product.Color(128, 211, 128);
            colormanager["flame"] = new Prototype.Product.Color(211, 34, 20);

            // User clones selected colors
            var color1 = colormanager["red"].Clone() as Prototype.Product.Color;
            var color2 = colormanager["peace"].Clone() as Prototype.Product.Color;
            var color3 = colormanager["flame"].Clone() as Prototype.Product.Color;
        }

        /// <summary>
        /// The singleton pattern ensures that only one object of a particular class is ever created. 
        /// All further references to objects of the singleton class refer to the same underlying instance.
        /// </summary>
        static void RunSingleton()
        {
            var b1 = Singleton.LoadBalancer.GetLoadBalancer();
            var b2 = Singleton.LoadBalancer.GetLoadBalancer();
            var b3 = Singleton.LoadBalancer.GetLoadBalancer();
            var b4 = Singleton.LoadBalancer.GetLoadBalancer();

            // Confirm these are the same instance
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Next, load balance 15 requests for a server
            var balancer = Singleton.LoadBalancer.GetLoadBalancer();

            for (int i = 0; i < 15; i++)
            {
                string serverName = balancer.NextServer.Name;
                Console.WriteLine($"Dispatch request to: {serverName}");
            }
        }

        /// <summary>
        /// The adapter pattern is used to provide a link between two otherwise incompatible types by 
        /// wrapping the "adaptee" with a class that supports the interface required by the client.
        /// </summary>
        static void RunAdapter()
        {
            // Non-adapted chemical compound
            var unknown = new Adapter.Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            var water = new Adapter.RichCompound("Water");
            water.Display();

            var benzene = new Adapter.RichCompound("Benzene");
            benzene.Display();

            var ethanol = new Adapter.RichCompound("Ethanol");
            ethanol.Display();
        }

        /// <summary>
        /// The bridge pattern is used to separate the abstract elements of a class from the implementation details, 
        /// providing the means to replace the implementation details without modifying the abstraction.
        /// </summary>
        static void RunBridge()
        {
            // Create RefinedAbstraction
            var customers = new Bridge.Customers("Chicago")
            {
                // Set ConcreteImplementor
                Data = new Bridge.CustomersData()
            };
                        
            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();
        }
    }
}
