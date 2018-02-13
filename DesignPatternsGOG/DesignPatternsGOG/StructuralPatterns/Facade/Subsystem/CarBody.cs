using System;

namespace DesignPatternsGOG.StructuralPatterns.Facade.Subsystem
{
    /// <summary>
    /// These are classes within complex system and offer detailed operations.
    /// </summary>
    class CarBody
    {
        public void SetBody()
        {
            Console.WriteLine("CarBody - SetBody");
        }
    }
}
