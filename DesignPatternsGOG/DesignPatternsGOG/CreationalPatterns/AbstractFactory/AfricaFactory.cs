using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Base;
using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product;
using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product.Base;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
