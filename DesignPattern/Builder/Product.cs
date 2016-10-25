using System;
using System.Collections.Generic;

namespace Builder
{
    public class Product
    {
        public List<string> _parts;

        public Product()
        {
            _parts = new List<string>();
        }
        public void Add(string p)
        {
            _parts.Add(p);
        }
        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}
