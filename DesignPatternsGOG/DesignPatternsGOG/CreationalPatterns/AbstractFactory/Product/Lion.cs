using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product.Base;
using System;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine($"{GetType().Name} eats {herbivore.GetType().Name}");
        }
    }
}
