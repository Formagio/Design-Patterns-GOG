using DesignPatternsGOG.CreationalPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory.Client
{
    /// <summary>
    /// This is a class which use AbstractFactory and AbstractProduct interfaces to create a family of related objects.
    /// </summary>
    class VehicleClient
    {
        IBike bike;
        IScooter scooter;

        public VehicleClient(IVehicleFactory factory, string type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }
    }
}
