using DesignPatternsGOG.CreationalPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory.ConcreteProduct
{
    /// <summary>
    /// This is a class which implements the AbstractProduct interface to create product.
    /// </summary>
    class SportsBike : IBike
    {
        public string Name()
        {
            return "Sports Bike - Name";
        }
    }
}
