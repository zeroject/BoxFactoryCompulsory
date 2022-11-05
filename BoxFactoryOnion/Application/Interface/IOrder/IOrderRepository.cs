using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interface.IOrder
{
    public interface IOrderRepository
    {
        public Order CreateNewOrder(Order order);
        public List<Order> GetAllOrders();
        public Order UpdateOrder(Order order);
        public void DeleteOrder(Order order);
    }
}
