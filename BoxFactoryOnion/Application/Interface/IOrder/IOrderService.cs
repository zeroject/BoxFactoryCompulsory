using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IOrder
{
    public interface IOrderService
    {
        public Order CreateNewOrder(Order order);
        public List<Order> GetAllOrders();
    }
}
