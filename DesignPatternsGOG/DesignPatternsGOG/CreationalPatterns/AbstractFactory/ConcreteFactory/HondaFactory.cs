using DesignPatternsGOG.CreationalPatterns.AbstractFactory.AbstractProduct;
using DesignPatternsGOG.CreationalPatterns.AbstractFactory.ConcreteProduct;
using System;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory.ConcreteFactory
{
    /// <summary>
    /// This is a class which implements the AbstractFactory interface to create concrete products.
    /// </summary>
    class HondaFactory : IVehicleFactory
    {
        public IBike GetBike(string Bike)
        {
            switch (Bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException($"Vehicle '{Bike}' cannot be created");
            }
        }

        public IScooter GetScooter(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException($"Vehicle '{Scooter}' cannot be created");
            }
        }
    }
}
