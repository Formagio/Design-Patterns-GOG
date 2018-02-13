using System;

namespace DesignPatternsGOG.StructuralPatterns.Bridge.Implementor
{
    /// <summary>
    /// These are classes which implement the Bridge interface and also provide the implementation details 
    /// for the associated Abstraction class.
    /// </summary>
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Web Service\n{subject}\n{body}\n");
        }
    }
}
