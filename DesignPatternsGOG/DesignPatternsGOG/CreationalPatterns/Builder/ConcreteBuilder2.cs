namespace DesignPatternsGOG.CreationalPatterns.Builder
{
    class ConcreteBuilder2 : Base.Builder
    {
        private Product.Product _product = new Product.Product();

        public override void BuildPartA()
        {
            _product.Add("PartX");
        }

        public override void BuildPartB()
        {
            _product.Add("PartY");
        }

        public override Product.Product GetResult()
        {
            return _product;
        }
    }
}
