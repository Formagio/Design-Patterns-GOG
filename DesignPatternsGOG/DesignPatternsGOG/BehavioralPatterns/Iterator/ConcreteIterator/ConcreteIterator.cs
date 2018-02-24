using DesignPatternsGOG.BehavioralPatterns.Iterator.Aggregate;
using System;

namespace DesignPatternsGOG.BehavioralPatterns.Iterator
{
    /// <summary>
    /// This is a class that implements Iterator interface.
    /// </summary>
    class ConcreteIterator : IIterator
    {
        private ConcreteAggregate _aggregate;
        int index;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
            index = -1;
        }

        public bool Next()
        {
            index++;
            return index < _aggregate.Count;
        }

        public object Current
        {
            get
            {
                if (index < _aggregate.Count)
                    return _aggregate[index];
                else
                    throw new InvalidOperationException();
            }
        }
    }
}
