using System;

namespace DesignPatternsGOG.BehavioralPatterns.Mediator
{
    /// <summary>
    /// These are the classes that communicate with each other via the mediator.
    /// </summary>
    class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(IMediator mediator) 
            : base(mediator)
        {
        }

        public void Send(string msg)
        {
            Console.WriteLine($"A send message: {msg}");
            _mediator.SendMessage(this, msg);
        }

        public void Receive(string msg)
        {
            Console.WriteLine($"A receive message: {msg}");
        }
    }
}
