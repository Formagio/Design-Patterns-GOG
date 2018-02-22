using System.Collections.Generic;

namespace DesignPatternsGOG.BehavioralPatterns.Command.Invoker
{
    /// <summary>
    /// Asks the command to carry out the action. 
    /// </summary>
    class Switch
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }
}
