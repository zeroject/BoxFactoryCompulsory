using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class OrderRepository
    {
        public Order CreateNewOrder(Order order)
        {
            return order;
        }

        public List<Order> GetOrders()
        {
            return new List<Order>()
            {
                new Order(){ Id = 1, BoxIDList = new List<int>(){1,2,4}, CustomerID=1, DateTime=new DateTime(2022, 5, 23), isDone=false, StatusCode="", TotalPrice=0},
                new Order(){ Id = 2, BoxIDList = new List<int>(){2,2,2}, CustomerID=3, DateTime=new DateTime(2022, 6, 12), isDone=true, StatusCode="shipped", TotalPrice=0},
            };
        }
    }
}
