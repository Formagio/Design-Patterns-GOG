using System;
using AbstractFactory = DesignPatternsGOG.CreationalPatterns.AbstractFactory;
using Adapter = DesignPatternsGOG.StructuralPatterns.Adapter;
using Bridge = DesignPatternsGOG.StructuralPatterns.Bridge;
using Builder = DesignPatternsGOG.CreationalPatterns.Builder;
using Composite = DesignPatternsGOG.StructuralPatterns.Composite;
using Decorator = DesignPatternsGOG.StructuralPatterns.Decorator;
using Facade = DesignPatternsGOG.StructuralPatterns.Facade;
using FactoryMethod = DesignPatternsGOG.CreationalPatterns.FactoryMethod;
using FlyWeight = DesignPatternsGOG.StructuralPatterns.Flyweight;
using Prototype = DesignPatternsGOG.CreationalPatterns.Prototype;
using Proxy = DesignPatternsGOG.StructuralPatterns.Proxy;
using Singleton = DesignPatternsGOG.CreationalPatterns.Singleton;

namespace DesignPatternsGOG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creational Patterns
            Console.WriteLine("Abstract Factory...");
            RunAbstractFactory();

            Console.WriteLine("\nBuilder...");
            RunBuilder();

            Console.WriteLine("\nFactory Method...");
            RunFactoryMethod();

            Console.WriteLine("\nPrototype...");
            RunPrototype();

            Console.WriteLine("\nSingleton...");
            RunSingleton();

            // Structural Patterns
            Console.WriteLine("\nAdapter...");
            RunAdapter();

            Console.WriteLine("\nBridge...");
            RunBridge();

            Console.WriteLine("\nComposite...");
            RunComposite();

            Console.WriteLine("\nDecorator...");
            RunDecorator();

            Console.WriteLine("\nFaçade...");
            RunFacade();

            Console.WriteLine("\nFlyWeight...");
            RunFlyWeight();

            Console.WriteLine("\nProxy...");
            RunProxy();

            // Wait for user input
            Console.ReadKey();
        }

        /// <summary>
        /// Abstract Factory patterns acts a super-factory which creates other factories. 
        /// This pattern is also called as Factory of factories. 
        /// In Abstract Factory pattern an interface is responsible for creating a set of related objects, 
        /// or dependent objects without specifying their concrete classes.
        /// http://www.dotnettricks.com/learn/designpatterns/abstract-factory-design-pattern-dotnet
        /// </summary>
        static void RunAbstractFactory()
        {
            AbstractFactory.IVehicleFactory honda = new AbstractFactory.ConcreteFactory.HondaFactory();
            AbstractFactory.Client.VehicleClient hondaclient = new AbstractFactory.Client.VehicleClient(honda, "Regular");

            Console.WriteLine("******* Honda **********");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            hondaclient = new AbstractFactory.Client.VehicleClient(honda, "Sports");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            AbstractFactory.IVehicleFactory hero = new AbstractFactory.ConcreteFactory.HeroFactory();
            AbstractFactory.Client.VehicleClient heroclient = new AbstractFactory.Client.VehicleClient(hero, "Regular");

            Console.WriteLine("******* Hero **********");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());

            heroclient = new AbstractFactory.Client.VehicleClient(hero, "Sports");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());
        }

        /// <summary>
        /// Builder pattern builds a complex object by using a step by step approach. 
        /// Builder interface defines the steps to build the final object. 
        /// This builder is independent from the objects creation process. 
        /// A class that is known as Director, controls the object creation process.
        /// Moreover, builder pattern describes a way to separate an object from its construction.
        /// The same construction method can create different representation of the object.
        /// http://www.dotnettricks.com/learn/designpatterns/builder-design-pattern-dotnet
        /// </summary>
        static void RunBuilder()
        {
            var vehicleCreator = new Builder.Director.VehicleCreator(new Builder.ConcreteBuilder.HeroBuilder());
            vehicleCreator.CreateVehicle();

            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");

            vehicleCreator = new Builder.Director.VehicleCreator(new Builder.ConcreteBuilder.HondaBuilder());
            vehicleCreator.CreateVehicle();

            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();
        }

        /// <summary>
        /// In Factory pattern, we create object without exposing the creation logic. 
        /// In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate.
        /// The creation of object is done when it is required. 
        /// The Factory method allows a class later instantiation to subclasses.
        /// http://www.dotnettricks.com/learn/designpatterns/factory-method-design-pattern-dotnet
        /// </summary>
        static void RunFactoryMethod()
        {
            var factory = new FactoryMethod.ConcreteCreator.ConcreteVehicleFactory();

            FactoryMethod.Product.IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            FactoryMethod.Product.IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);
        }

        /// <summary>
        /// Prototype pattern is used to create a duplicate object or clone of the current object to enhance performance. 
        /// This pattern is used when creation of object is costly or complex.
        /// For Example: An object is to be created after a costly database operation.
        /// We can cache the object, returns its clone on next request and update the database as and when needed thus reducing database calls.
        /// http://www.dotnettricks.com/learn/designpatterns/prototype-design-pattern-dotnet
        /// </summary>
        static void RunPrototype()
        {
            var dev = new Prototype.ConcretePrototype.Developer
            {
                Name = "Rahul",
                Role = "Team Leader",
                PreferredLanguage = "C#"
            };

            var devCopy = (Prototype.ConcretePrototype.Developer)dev.Clone();
            devCopy.Name = "Arif"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            var typist = new Prototype.ConcretePrototype.Typist
            {
                Name = "Monu",
                Role = "Typist",
                WordsPerMinute = 120
            };

            var typistCopy = (Prototype.ConcretePrototype.Typist)typist.Clone();
            typistCopy.Name = "Sahil";
            typistCopy.WordsPerMinute = 115; //Not mention Role, it will copy above

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());
        }

        /// <summary>
        /// Singleton pattern is one of the simplest design patterns. 
        /// This pattern ensures that a class has only one instance and provides a global point of access to it.
        /// http://www.dotnettricks.com/learn/designpatterns/singleton-design-pattern-dotnet
        /// </summary>
        static void RunSingleton()
        {
            Singleton.Singleton.Instance.Show();
            Singleton.Singleton.Instance.Show();
        }

        /// <summary>
        /// Adapter pattern acts as a bridge between two incompatible interfaces. 
        /// This pattern involves a single class called adapter which is responsible for communication between 
        /// two independent or incompatible interfaces.
        /// For Example: A card reader acts as an adapter between memory card and a laptop.
        /// You plugins the memory card into card reader and card reader into the laptop so that memory card can
        /// be read via laptop.
        /// http://www.dotnettricks.com/learn/designpatterns/adapter-design-pattern-dotnet
        /// </summary>
        static void RunAdapter()
        {
            Adapter.ITarget Itarget = new Adapter.EmployeeAdapter();
            Adapter.Client.ThirdPartyBillingSystem client = new Adapter.Client.ThirdPartyBillingSystem(Itarget);

            client.ShowEmployeeList();
        }

        /// <summary>
        /// Bridge pattern is used to separate an abstraction from its implementation so that both can be modified independently. 
        /// This pattern involves an interface which acts as a bridge between the abstraction class and implementer classes 
        /// and also makes the functionality of implementer class independent from the abstraction class. 
        /// Both types of classes can be modified without affecting to each other.
        /// http://www.dotnettricks.com/learn/designpatterns/bridge-design-pattern-dotnet
        /// </summary>
        static void RunBridge()
        {
            Bridge.IMessageSender email = new Bridge.Implementor.EmailSender();
            Bridge.IMessageSender queue = new Bridge.Implementor.MSMQSender();
            Bridge.IMessageSender web = new Bridge.Implementor.WebServiceSender();

            Bridge.Abstraction.Message message = new Bridge.RefinedAbstraction.SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";

            message.MessageSender = email;
            message.Send();

            message.MessageSender = queue;
            message.Send();

            message.MessageSender = web;
            message.Send();

            Bridge.RefinedAbstraction.UserMessage usermsg = new Bridge.RefinedAbstraction.UserMessage();
            usermsg.Subject = "Test Message";
            usermsg.Body = "Hi, This is a Test Message";
            usermsg.UserComments = "I hope you are well";

            usermsg.MessageSender = email;
            usermsg.Send();
        }

        /// <summary>
        /// Composite pattern is used to separate an abstraction from its implementation so that both can be modified independently. 
        /// Composite pattern is used when we need to treat a group of objects and a single object in the same way.
        /// Composite pattern composes objects in term of a tree structure to represent part as well as whole hierarchies.
        /// This pattern creates a class contains group of its own objects.This class provides ways to modify its group of same objects.
        /// http://www.dotnettricks.com/learn/designpatterns/composite-design-pattern-dotnet
        /// </summary>
        static void RunComposite()
        {
            var Rahul = new Composite.Employee { EmpID = 1, Name = "Rahul" };
            var Amit = new Composite.Employee { EmpID = 2, Name = "Amit" };
            var Mohan = new Composite.Employee { EmpID = 3, Name = "Mohan" };

            Rahul.AddSubordinate(Amit);
            Rahul.AddSubordinate(Mohan);

            var Rita = new Composite.Employee { EmpID = 4, Name = "Rita" };
            var Hari = new Composite.Employee { EmpID = 5, Name = "Hari" };

            Amit.AddSubordinate(Rita);
            Amit.AddSubordinate(Hari);

            var Kamal = new Composite.Employee { EmpID = 6, Name = "Kamal" };
            var Raj = new Composite.Employee { EmpID = 7, Name = "Raj" };

            var Sam = new Composite.Leaf.Contractor { EmpID = 8, Name = "Sam" };
            var tim = new Composite.Leaf.Contractor { EmpID = 9, Name = "Tim" };

            Mohan.AddSubordinate(Kamal);
            Mohan.AddSubordinate(Raj);
            Mohan.AddSubordinate(Sam);
            Mohan.AddSubordinate(tim);

            Console.WriteLine($"EmpID={Rahul.EmpID}, Name={Rahul.Name}");

            foreach (Composite.Employee manager in Rahul)
            {
                Console.WriteLine($"\n EmpID={manager.EmpID}, Name={manager.Name}");

                foreach (var employee in manager)
                {
                    Console.WriteLine($" \t EmpID={employee.EmpID}, Name={employee.Name}");
                }
            }
        }

        /// <summary>
        /// Decorator pattern is used to add new functionality to an existing object without changing its structure.
        /// This pattern creates a decorator class which wraps the original class and add new behaviors/operations to an object at run-time.
        /// http://www.dotnettricks.com/learn/designpatterns/decorator-design-pattern-dotnet
        /// </summary>
        static void RunDecorator()
        {
            // Basic vehicle
            var car = new Decorator.ConcreteComponent.HondaCity();

            Console.WriteLine($"Honda City base price are : {car.Price}");

            // Special offer
            var offer = new Decorator.ConcreteDecorator.SpecialOffer(car)
            {
                DiscountPercentage = 25,
                Offer = "25 % discount"
            };

            Console.WriteLine($"{offer.Price} @ Diwali Special Offer and price are : {offer.Offer}");
        }

        /// <summary>
        /// Facade pattern hides the complexities of the system and provides an interface to the client using which 
        /// the client can access the system.
        /// This pattern involves a single wrapper class which contains a set of members which are required by client.
        /// These members access the system on behalf of the facade client and hide the implementation details.
        /// The facade design pattern is particularly used when a system is very complex or difficult to understand because 
        /// system has a large number of interdependent classes or its source code is unavailable.
        /// http://www.dotnettricks.com/learn/designpatterns/facade-design-pattern-dotnet
        /// </summary>
        static void RunFacade()
        {
            var facade = new Facade.CarFacade();

            facade.CreateCompleteCar();
        }

        /// <summary>
        /// Flyweight pattern is used to reduce the number of objects created, to decrease memory and resource usage. As a result it increase performance.
        /// Flyweight pattern try to reuse already existing similar kind objects by storing them and creates new object when no matching object is found.
        /// The flyweight pattern uses the concepts of intrinsic and extrinsic data.
        /// Intrinsic data is held in the properties of the shared flyweight objects.
        /// This information is stateless and generally remains unchanged, if any change occurs it would be reflected among all of the objects that reference the flyweight.
        /// Extrinsic data is computed on the fly means at runtime and it is held outside of a flyweight object. 
        /// Hence it can be stateful.
        /// http://www.dotnettricks.com/learn/designpatterns/flyweight-design-pattern-dotnet
        /// </summary>
        static void RunFlyWeight()
        {
            var sof = new FlyWeight.FlyweightFactory.ShapeObjectFactory();
            var shape = sof.GetShape("Rectangle");

            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();

            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();

            int NumObjs = sof.TotalObjectsCreated;
            Console.WriteLine($"Total No of Objects created = {NumObjs}");
        }

        /// <summary>
        /// The proxy design pattern is used to provide a surrogate object, which references to other object.
        /// Proxy pattern involves a class, called proxy class, which represents functionality of another class.
        /// http://www.dotnettricks.com/learn/designpatterns/proxy-design-pattern-dotnet
        /// </summary>
        static void RunProxy()
        {
            var proxy = new Proxy.ProxyClient();
            Console.WriteLine($"Data from Proxy Client = {proxy.GetData()}");
        }
    }
}
