using Application.DTOs;
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

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }
    }
}
