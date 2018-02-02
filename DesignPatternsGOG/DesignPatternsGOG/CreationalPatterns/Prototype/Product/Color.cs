using DesignPatternsGOG.CreationalPatterns.Prototype.Base;
using System;

namespace DesignPatternsGOG.CreationalPatterns.Prototype.Product
{
    class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine($"Cloning color RGB: {_red},{_green},{_blue}");

            return MemberwiseClone() as ColorPrototype;
        }
    }
}
