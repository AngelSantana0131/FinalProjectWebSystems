using System.Collections.Generic;

namespace FinalProjectWebSystems.Models
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
