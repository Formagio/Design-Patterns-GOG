namespace DesignPatternsGOG.BehavioralPatterns.Iterator.Aggregate
{
    /// <summary>
    /// This is an interface which defines an operation to create an iterator.
    /// </summary>
    interface IAggregate
    {
        IIterator CreateIterator();
    }
}
