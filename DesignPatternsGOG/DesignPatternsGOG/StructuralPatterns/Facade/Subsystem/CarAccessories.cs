using System;

namespace DesignPatternsGOG.StructuralPatterns.Facade.Subsystem
{
    /// <summary>
    /// These are classes within complex system and offer detailed operations.
    /// </summary>
    class CarAccessories
    {
        public void SetAccessories()
        {
            Console.WriteLine("CarAccessories - SetAccessories");
        }
    }
}
