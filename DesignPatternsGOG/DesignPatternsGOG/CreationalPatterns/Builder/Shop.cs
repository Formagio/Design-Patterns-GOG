using DesignPatternsGOG.CreationalPatterns.Builder.Base;

namespace DesignPatternsGOG.CreationalPatterns.Builder
{
    class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
