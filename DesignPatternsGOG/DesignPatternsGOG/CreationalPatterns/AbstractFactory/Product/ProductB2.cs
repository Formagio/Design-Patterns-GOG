using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product.Base;
using System;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product
{
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine($"{GetType().Name} interacts with {a.GetType().Name}");
        }
    }
}
