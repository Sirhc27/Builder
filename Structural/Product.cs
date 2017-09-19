using System;
using System.Collections.Generic;

namespace Structural
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    internal class Product
    {
        private readonly List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (var part in _parts)
                Console.WriteLine(part);
        }
    }
}