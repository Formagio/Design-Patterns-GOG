using DesignPatternsGOG.StructuralPatterns.Bridge.Abstraction;

namespace DesignPatternsGOG.StructuralPatterns.Bridge.RefinedAbstraction
{
    /// <summary>
    /// This is a class which inherits from the Abstraction class. 
    /// It extends the interface defined by Abstraction class.
    /// </summary>
    class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}
