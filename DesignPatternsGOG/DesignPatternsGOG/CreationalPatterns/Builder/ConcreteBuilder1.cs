namespace DesignPatternsGOG.CreationalPatterns.Builder
{
    class ConcreteBuilder1 : Base.Builder
    {
        private Product.Product _product = new Product.Product();

        public override void BuildPartA()
        {
            _product.Add("PartA");
        }

        public override void BuildPartB()
        {
            _product.Add("PartB");
        }

        public override Product.Product GetResult()
        {
            return _product;
        }
    }
}
