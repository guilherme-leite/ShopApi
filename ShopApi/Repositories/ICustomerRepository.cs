using ShopApi.Models;

namespace ShopApi.Repositories
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
    }
}
