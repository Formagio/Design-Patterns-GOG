using DesignPatternsGOG.StructuralPatterns.Facade.Subsystem;
using System;

namespace DesignPatternsGOG.StructuralPatterns.Facade
{
    /// <summary>
    /// This is a wrapper class which wrapper class which contains a set of members which are required by client.
    /// </summary>
    class CarFacade
    {
        CarModel model;
        CarEngine engine;
        CarBody body;
        CarAccessories accessories;

        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");

            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}
