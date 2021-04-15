using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWebSystems.Models
{
    interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
