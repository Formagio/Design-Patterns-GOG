using System;

namespace DesignPatternsGOG.StructuralPatterns.Facade.Subsystem
{
    /// <summary>
    /// These are classes within complex system and offer detailed operations.
    /// </summary>
    class CarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine("CarEngine - SetEngine");
        }
    }
}
