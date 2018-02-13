using DesignPatternsGOG.CreationalPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory
{
    /// <summary>
    /// This is an interface which is used to create abstract product.
    /// </summary>
    interface IVehicleFactory
    {
        IBike GetBike(string Bike);
        IScooter GetScooter(string Scooter);
    }
}
