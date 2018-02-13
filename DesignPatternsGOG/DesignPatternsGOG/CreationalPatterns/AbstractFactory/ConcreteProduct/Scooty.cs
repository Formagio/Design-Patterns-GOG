using DesignPatternsGOG.CreationalPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory.ConcreteProduct
{
    /// <summary>
    /// This is a class which implements the AbstractProduct interface to create product.
    /// </summary>
    class Scooty : IScooter
    {
        public string Name()
        {
            return "Scooty - Name";
        }
    }
}
