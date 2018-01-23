namespace DesignPatternsGOG.CreationalPatterns.Builder
{
    class Director
    {
        // Builder uses a complex series of steps
        public void Construct(Base.Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
