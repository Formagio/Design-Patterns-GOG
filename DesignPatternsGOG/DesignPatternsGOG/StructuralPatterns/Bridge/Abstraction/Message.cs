namespace DesignPatternsGOG.StructuralPatterns.Bridge.Abstraction
{
    /// <summary>
    /// This is an abstract class and containing members that define an abstract business object and its functionality. 
    /// It contains a reference to an object of type Bridge. It can also acts as the base class for other abstractions.
    /// </summary>
    abstract class Message
    {
        public IMessageSender MessageSender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public abstract void Send();
    }
}
