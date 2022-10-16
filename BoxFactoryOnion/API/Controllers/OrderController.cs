using Application.DTOs;
using Application.Interface.IOrder;
using Domain.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public List<Order> GetAllCustomers()
        {
            return _orderService.GetAllOrders();
        }

        [HttpPost]
        public ActionResult<Order> CreateNewCustomer(Order order)
        {
            try
            {
                var result = _orderService.CreateNewOrder(order);
                return Created("customer/" + result.Id, result);
            }
            catch (ValidationException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
