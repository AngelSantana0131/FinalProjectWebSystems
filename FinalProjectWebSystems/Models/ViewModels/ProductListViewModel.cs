using System.Collections.Generic;
using FinalProjectWebSystems.Models;
namespace FinalProjectWebSystems.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
