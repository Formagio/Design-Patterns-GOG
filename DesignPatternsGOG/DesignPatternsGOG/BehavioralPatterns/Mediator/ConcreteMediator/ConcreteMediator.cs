namespace DesignPatternsGOG.BehavioralPatterns.Mediator
{
    /// <summary>
    /// This is a class that implement the communication operations of the Mediator interface.
    /// </summary>
    class ConcreteMediator : IMediator
    {
        public ConcreteColleagueA ColleagueA { get; set; }

        public ConcreteColleagueB ColleagueB { get; set; }

        public void SendMessage(Colleague caller, string msg)
        {
            if (caller == ColleagueA)
                ColleagueB.Receive(msg);
            else
                ColleagueA.Receive(msg);
        }
    }
}
