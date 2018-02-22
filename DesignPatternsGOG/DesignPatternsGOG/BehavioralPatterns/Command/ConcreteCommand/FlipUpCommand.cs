using DesignPatternsGOG.BehavioralPatterns.Command.Receiver;

namespace DesignPatternsGOG.BehavioralPatterns.Command.ConcreteCommand
{
    /// <summary>
    /// This is a class that implements the Execute operation by invoking operation(s) on the Receiver.
    /// </summary>
    class FlipUpCommand : ICommand
    {
        private Light _light;

        public FlipUpCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
