using Microsoft.AspNetCore.Mvc;
using ShopApi.Models;
using ShopApi.Repositories;

namespace ShopApi.Controllers
{
    [ApiController]
    [Route("/orders")]
    public class OrderController : ControllerBase
    {
        public Order Post(
            [FromServices] ICustomerRepository custumerRepository,
            [FromServices] IOrderRepository orderRepository)
        {
            try {
            var customer = new Customer { Name = "Guilherme Leite" };
            var order = new Order { Number = "1", Customer = customer };

            custumerRepository.Save(customer);
            orderRepository.Save(order);

            return order;

            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
