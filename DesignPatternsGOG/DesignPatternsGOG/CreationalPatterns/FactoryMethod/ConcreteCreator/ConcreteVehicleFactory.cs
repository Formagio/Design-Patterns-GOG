using DesignPatternsGOG.CreationalPatterns.FactoryMethod.ConcreteProduct;
using DesignPatternsGOG.CreationalPatterns.FactoryMethod.Creator;
using DesignPatternsGOG.CreationalPatterns.FactoryMethod.Product;
using System;

namespace DesignPatternsGOG.CreationalPatterns.FactoryMethod.ConcreteCreator
{
    /// <summary>
    /// This is a class which implements the Creator class and overrides the factory method 
    /// to return an instance of a ConcreteProduct.
    /// </summary>
    class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException($"Vehicle '{vehicle}' cannot be created");
            }
        }
    }
}
