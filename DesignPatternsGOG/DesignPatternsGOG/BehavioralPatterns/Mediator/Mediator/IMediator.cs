namespace DesignPatternsGOG.BehavioralPatterns.Mediator
{
    /// <summary>
    /// This is an interface that defines operations which can be called by colleague objects for communication.
    /// </summary>
    interface IMediator
    {
        void SendMessage(Colleague caller, string msg);
    }
}
