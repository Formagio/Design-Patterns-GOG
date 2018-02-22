using DesignPatternsGOG.BehavioralPatterns.Command.Receiver;

namespace DesignPatternsGOG.BehavioralPatterns.Command.ConcreteCommand
{
    /// <summary>
    /// This is a class that implements the Execute operation by invoking operation(s) on the Receiver.
    /// </summary>
    class FlipDownCommand : ICommand
    {
        private Light _light;

        public FlipDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
