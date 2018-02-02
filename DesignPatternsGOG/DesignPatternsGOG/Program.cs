﻿using System;
using AbstractFactory = DesignPatternsGOG.CreationalPatterns.AbstractFactory;
using Builder = DesignPatternsGOG.CreationalPatterns.Builder;
using FactoryMethod = DesignPatternsGOG.CreationalPatterns.FactoryMethod;
using Prototype = DesignPatternsGOG.CreationalPatterns.Prototype;

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
    }
}
