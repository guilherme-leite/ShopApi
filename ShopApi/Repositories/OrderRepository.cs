﻿using ShopApi.Data;
using ShopApi.Models;

namespace ShopApi.Repositories
{
    public class OrderRepository : IOrderRepository
    {   
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Order order)
        {
            _context.Orders.Add(order);
        }
    }
}
