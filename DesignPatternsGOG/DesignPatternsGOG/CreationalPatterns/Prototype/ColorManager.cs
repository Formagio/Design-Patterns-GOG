using DesignPatternsGOG.CreationalPatterns.Prototype.Base;
using System.Collections.Generic;

namespace DesignPatternsGOG.CreationalPatterns.Prototype
{
    class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors;

        public ColorManager()
        {
            _colors = new Dictionary<string, ColorPrototype>();
        }

        // Indexer
        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
