using System;
using System.Collections.Generic;

namespace DesignPatternsGOG.CreationalPatterns.Builder.Product
{
    class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Product Parts");

            foreach (string part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
