using System;

namespace DesignPatternsGOG.StructuralPatterns.Flyweight.ConcreteFlyweight
{
    /// <summary>
    /// This is a class which Inherits from the Flyweight class.
    /// </summary>
    class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
    }
}
