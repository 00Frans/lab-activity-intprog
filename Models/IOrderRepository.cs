using Fat_SportsStore.Models;

namespace Fat_SportsStore.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}