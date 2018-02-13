using DesignPatternsGOG.CreationalPatterns.Builder.Product;

namespace DesignPatternsGOG.CreationalPatterns.Builder.ConcreteBuilder
{
    /// <summary>
    /// This is a class which implements the Builder interface to create complex product.
    /// </summary>
    class HondaBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();

        public void SetModel()
        {
            objVehicle.Model = "Honda";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "125 Km/hr";
        }

        public void SetBody()
        {
            objVehicle.Body = "Plastic";
        }

        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
            objVehicle.Accessories.Add("Helmet");
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}
