using Application.DTOs;
using Application.Interface.ICustomer;
using Application.Interface.IOrder;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IMapper _mapper;
        private IValidator<GetOrderDTO> _getValidator;
        public OrderService(IOrderRepository orderRepository, IMapper mapper, IValidator<GetOrderDTO> getValidator)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _getValidator = getValidator;
        }

        public Order CreateNewOrder(Order order)
        {
            return _orderRepository.CreateNewOrder(order);
        }

        public void DeleteOrder(Order order)
        {
            _orderRepository.DeleteOrder(order);
        }

        public List<GetOrderDTO> GetAllOrders()
        {
            List<Order> orders = _orderRepository.GetAllOrders();
            List<GetOrderDTO> getOrderDTOs = new List<GetOrderDTO>();
            foreach (var item in orders)
            {
                var temp = new GetOrderDTO { DateTime = item.DateTime, Id = item.Id, StatusCode = item.StatusCode, TotalPrice = item.TotalPrice };
                getOrderDTOs.Add(temp);
            }
            return getOrderDTOs;
        }

        public Order UpdateOrder(Order order)
        {
            return _orderRepository.UpdateOrder(order);
        }
    }
}
