using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product.Base;
using System;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine($"{GetType().Name} eats {herbivore.GetType().Name}");
        }
    }
}
