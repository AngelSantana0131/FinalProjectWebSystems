using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWebSystems.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product {Name = "Nike Air Force 1", Price = 90},
            new Product {Name = "Nike Air Max 90", Price = 120},
            new Product {Name = "Jordan True Flight", Price = 140},
            new Product {Name = "Adidas NMD R1", Price = 130},
            new Product {Name = "Nike Air VaporMax Flyknit 3", Price = 200}
        };
    }
}
