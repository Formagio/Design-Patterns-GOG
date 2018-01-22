using DesignPatternsGOG.CreationalPatterns.AbstractFactory.Product.Base;

namespace DesignPatternsGOG.CreationalPatterns.AbstractFactory
{
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;
        
        public Client(Base.AbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
