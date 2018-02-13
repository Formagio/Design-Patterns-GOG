using DesignPatternsGOG.StructuralPatterns.Decorator.Component;

namespace DesignPatternsGOG.StructuralPatterns.Decorator
{
    /// <summary>
    /// This is an abstract class which implements the Component interface and contains the reference to a Component instance. 
    /// This class also acts as base class for all decorators for components.
    /// </summary>
    abstract class VehicleDecorator : IVehicle
    {
        private IVehicle _vehicle;

        public VehicleDecorator(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public string Make
        {
            get { return _vehicle.Make; }
        }

        public string Model
        {
            get { return _vehicle.Model; }
        }

        public double Price
        {
            get { return _vehicle.Price; }
        }
    }
}
