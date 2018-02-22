using System;

namespace DesignPatternsGOG.BehavioralPatterns.Command.Receiver
{
    /// <summary>
    /// This is a class that performs the Action associated with the request.
    /// </summary>
    class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off");
        }
    }
}
