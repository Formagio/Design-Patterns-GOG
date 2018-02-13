using DesignPatternsGOG.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatternsGOG.CreationalPatterns.FactoryMethod.Creator
{
    /// <summary>
    /// This is an abstract class and declares the factory method, which returns an object of type Product.
    /// </summary>
    abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string vehicle);
    }
}
