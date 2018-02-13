using DesignPatternsGOG.StructuralPatterns.Flyweight.ConcreteFlyweight;
using System;
using System.Collections.Generic;

namespace DesignPatternsGOG.StructuralPatterns.Flyweight.FlyweightFactory
{
    /// <summary>
    /// This is a class which holds the references of already created flyweight objects. 
    /// When the GetFlyweight method is called from client code, these references are checked to determine if 
    /// an appropriate flyweight object is already present or not. If present, it is returned. 
    /// Otherwise a new object is generated, added to the collection and returned.
    /// </summary>
    class ShapeObjectFactory
    {
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public int TotalObjectsCreated
        {
            get { return shapes.Count; }
        }

        public IShape GetShape(string ShapeName)
        {
            IShape shape = null;
            if (shapes.ContainsKey(ShapeName))
            {
                shape = shapes[ShapeName];
            }
            else
            {
                switch (ShapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        shapes.Add("Rectangle", shape);
                        break;
                    case "Circle":
                        shape = new Circle();
                        shapes.Add("Circle", shape);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }

            return shape;
        }
    }
}
