using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface;
using Application.Interface.IOrder;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private DbContextOptions<DBContext> _dbContextOptions;
        public OrderRepository()
        {
            _dbContextOptions = new DbContextOptionsBuilder<DBContext>()
                .UseSqlServer("").Options;
        }
        public Order CreateNewOrder(Order order)
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            context.Orders.Add(order);
            context.SaveChanges();
            return order;
        }

        public void DeleteOrder(Order order)
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            context.Orders.Remove(order);
            context.SaveChanges();
        }

        public List<Order> GetAllOrders()
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            return context.Orders.ToList();
        }

        public Order UpdateOrder(Order order)
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            context.Orders.Update(order);
            context.SaveChanges();
            return order;
        }
    }
}
