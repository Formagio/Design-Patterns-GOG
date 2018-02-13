namespace DesignPatternsGOG.StructuralPatterns.Decorator.Component
{
    /// <summary>
    /// This is an interface containing members that will be implemented by ConcreteClass and Decorator.
    /// </summary>
    interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        double Price { get; }
    }
}
