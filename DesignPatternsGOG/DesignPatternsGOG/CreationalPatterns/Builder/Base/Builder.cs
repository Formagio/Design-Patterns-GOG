namespace DesignPatternsGOG.CreationalPatterns.Builder.Base
{
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product.Product GetResult();
    }
}
