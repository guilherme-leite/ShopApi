using ShopApi.Models;

namespace ShopApi.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}
