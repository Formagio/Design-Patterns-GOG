namespace DesignPatternsGOG.BehavioralPatterns.Mediator
{
    /// <summary>
    /// This is a class that defines a single, protected field that holds a reference to a mediator.
    /// </summary>
    abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
