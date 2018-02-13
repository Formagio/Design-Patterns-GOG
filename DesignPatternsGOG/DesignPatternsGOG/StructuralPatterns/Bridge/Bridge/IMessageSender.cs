namespace DesignPatternsGOG.StructuralPatterns.Bridge
{
    /// <summary>
    /// This is an interface which acts as a bridge between the abstraction class and implementer classes 
    /// and also makes the functionality of implementer class independent from the abstraction class.
    /// </summary>
    interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}
