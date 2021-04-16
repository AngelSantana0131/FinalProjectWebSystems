using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWebSystems.Models
{
    public class Product
    {
        public int ProductId { get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
    }
}
