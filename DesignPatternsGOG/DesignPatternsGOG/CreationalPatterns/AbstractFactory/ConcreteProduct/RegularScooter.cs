using DesignPatternsGOG.CreationalPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory.ConcreteProduct
{
    /// <summary>
    /// This is a class which implements the AbstractProduct interface to create product.
    /// </summary>
    class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Regular Scooter - Name";
        }
    }
}
