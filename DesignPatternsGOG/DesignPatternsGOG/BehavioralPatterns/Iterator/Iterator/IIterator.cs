namespace DesignPatternsGOG.BehavioralPatterns.Iterator
{
    /// <summary>
    /// This is an interface that defines operations for accessing the collection elements in a sequence.
    /// </summary>
    interface IIterator
    {
        object Current { get; }
        bool Next();
    }
}
