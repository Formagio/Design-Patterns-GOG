using System.Collections;

namespace DesignPatternsGOG.BehavioralPatterns.Iterator.Aggregate
{
    /// <summary>
    /// This is a class that implements Aggregate interface.
    /// </summary>
    class ConcreteAggregate : IAggregate
    {
        private ArrayList items = new ArrayList();

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return items[index]; }
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Add(object o)
        {
            items.Add(o);
        }
    }
}
