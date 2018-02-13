using DesignPatternsGOG.StructuralPatterns.Composite.Component;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatternsGOG.StructuralPatterns.Composite
{
    /// <summary>
    /// This is a class which includes Add, Remove, Find and Get methods to do operations on child components.
    /// </summary>
    class Employee : IEmployed, IEnumerable<IEmployed>
    {
        private List<IEmployed> _subordinates = new List<IEmployed>();
        public int EmpID { get; set; }
        public string Name { get; set; }

        public void AddSubordinate(IEmployed subordinate)
        {
            _subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(IEmployed subordinate)
        {
            _subordinates.Remove(subordinate);
        }

        public IEmployed GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IEmployed> GetEnumerator()
        {
            foreach (IEmployed subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
