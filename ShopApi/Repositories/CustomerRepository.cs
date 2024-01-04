using ShopApi.Data;
using ShopApi.Models;

namespace ShopApi.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Customer customer)
        {
            _context.Add(customer);
        }
    }
}
