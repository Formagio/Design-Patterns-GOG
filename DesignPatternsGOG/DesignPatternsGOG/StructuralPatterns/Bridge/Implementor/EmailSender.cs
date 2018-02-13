using System;

namespace DesignPatternsGOG.StructuralPatterns.Bridge.Implementor
{
    /// <summary>
    /// These are classes which implement the Bridge interface and also provide the implementation details 
    /// for the associated Abstraction class.
    /// </summary>
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Email\n{subject}\n{body}\n");
        }
    }
}
