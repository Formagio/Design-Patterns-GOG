using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Base;
using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product;
using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product.Base;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory
{
    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
