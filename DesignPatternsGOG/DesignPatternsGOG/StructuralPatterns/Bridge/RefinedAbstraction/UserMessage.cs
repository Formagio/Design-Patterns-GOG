using DesignPatternsGOG.StructuralPatterns.Bridge.Abstraction;

namespace DesignPatternsGOG.StructuralPatterns.Bridge.RefinedAbstraction
{
    /// <summary>
    /// This is a class which inherits from the Abstraction class. 
    /// It extends the interface defined by Abstraction class.
    /// </summary>
    class UserMessage : Message
    {
        public string UserComments { get; set; }

        public override void Send()
        {
            string fullBody = $"{Body}\nUser Comments: {UserComments}";
            MessageSender.SendMessage(Subject, fullBody);
        }
    }
}
