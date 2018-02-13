using DesignPatternsGOG.StructuralPatterns.Decorator.Component;
using System;

namespace DesignPatternsGOG.StructuralPatterns.Decorator.ConcreteDecorator
{
    /// <summary>
    /// This is a class which inherits from Decorator class and provides a decorator for components.
    /// </summary>
    class SpecialOffer : VehicleDecorator
    {
        public SpecialOffer(IVehicle vehicle)
            : base(vehicle)
        {
        }

        public int DiscountPercentage { get; set; }
        public string Offer { get; set; }

        public new double Price
        {
            get
            {
                double price = base.Price;
                int percentage = 100 - DiscountPercentage;
                return Math.Round((price * percentage) / 100, 2);
            }
        }

    }
}
