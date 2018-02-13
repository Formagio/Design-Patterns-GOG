using System;

namespace DesignPatternsGOG.StructuralPatterns.Facade.Subsystem
{
    /// <summary>
    /// These are classes within complex system and offer detailed operations.
    /// </summary>
    class CarModel
    {
        public void SetModel()
        {
            Console.WriteLine("CarModel - SetModel");
        }
    }
}
