using System;

namespace DesignPatternsGOG.StructuralPatterns.Flyweight.ConcreteFlyweight
{
    /// <summary>
    /// This is a class which Inherits from the Flyweight class.
    /// </summary>
    class Circle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Circle");
        }
    }
}
