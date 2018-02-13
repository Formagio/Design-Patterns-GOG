using DesignPatternsGOG.CreationalPatterns.FactoryMethod.Product;
using System;

namespace DesignPatternsGOG.CreationalPatterns.FactoryMethod.ConcreteProduct
{
    /// <summary>
    /// This is a class which implements the Product interface.
    /// </summary>
    class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Drive the Bike : {miles}km");
        }
    }
}
