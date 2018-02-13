using DesignPatternsGOG.StructuralPatterns.Decorator.Component;

namespace DesignPatternsGOG.StructuralPatterns.Decorator.ConcreteComponent
{
    /// <summary>
    /// This is a class which implements the Component interface.
    /// </summary>
    class HondaCity : IVehicle
    {
        public string Make
        {
            get { return "HondaCity"; }
        }

        public string Model
        {
            get { return "CNG"; }
        }

        public double Price
        {
            get { return 1000000; }
        }
    }
}
