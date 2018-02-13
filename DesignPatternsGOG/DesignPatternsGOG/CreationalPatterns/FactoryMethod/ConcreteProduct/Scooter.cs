using DesignPatternsGOG.CreationalPatterns.FactoryMethod.Product;
using System;

namespace DesignPatternsGOG.CreationalPatterns.FactoryMethod.ConcreteProduct
{
    /// <summary>
    /// This is a class which implements the Product interface.
    /// </summary>
    class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Drive the Scooter : {miles}km");
        }
    }
}