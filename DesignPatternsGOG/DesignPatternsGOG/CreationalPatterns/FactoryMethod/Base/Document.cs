using DesignPatternsGOG.CreationalPatterns.FactoryMethod.Product.Base;
using System.Collections.Generic;

namespace DesignPatternsGOG.CreationalPatterns.FactoryMethod.Base
{
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();
        public List<Page> Pages => _pages;

        // Constructor calls abstract Factory method
        public Document()
        {
            CreatePages();
        }

        // Factory Method
        public abstract void CreatePages();
    }
}
