using DesignPatternsGOG.CreationalPatterns.Builder.Product;

namespace DesignPatternsGOG.CreationalPatterns.Builder.Director
{
    /// <summary>
    /// This is a class which is used to construct an object using the Builder interface.
    /// </summary>
    class VehicleCreator
    {
        private readonly IVehicleBuilder objBuilder;

        public VehicleCreator(IVehicleBuilder builder)
        {
            objBuilder = builder;
        }

        public void CreateVehicle()
        {
            objBuilder.SetModel();
            objBuilder.SetEngine();
            objBuilder.SetBody();
            objBuilder.SetTransmission();
            objBuilder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return objBuilder.GetVehicle();
        }
    }
}
