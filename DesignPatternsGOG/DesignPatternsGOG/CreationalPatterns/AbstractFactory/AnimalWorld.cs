using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Base;
using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product.Base;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory
{
    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;
        
        public AnimalWorld(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
