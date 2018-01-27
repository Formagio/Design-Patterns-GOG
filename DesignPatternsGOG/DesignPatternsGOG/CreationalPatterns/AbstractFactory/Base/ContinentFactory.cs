using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product.Base;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory.Base
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
