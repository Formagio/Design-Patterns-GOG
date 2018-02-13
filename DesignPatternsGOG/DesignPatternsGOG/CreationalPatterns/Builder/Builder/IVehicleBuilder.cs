using DesignPatternsGOG.CreationalPatterns.Builder.Product;

namespace DesignPatternsGOG.CreationalPatterns.Builder
{
    /// <summary>
    /// This is an interface which is used to define all the steps to create a product.
    /// </summary>
    interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetBody();
        void SetAccessories();

        Vehicle GetVehicle();
    }
}
