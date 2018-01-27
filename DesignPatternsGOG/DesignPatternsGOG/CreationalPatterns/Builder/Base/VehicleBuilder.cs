using DesignPatternsGOG.CreationalPatterns.Builder.Product;

namespace DesignPatternsGOG.CreationalPatterns.Builder.Base
{
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        
        public Vehicle Vehicle => vehicle;

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
