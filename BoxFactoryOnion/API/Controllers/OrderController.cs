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
        public List<GetOrderDTO> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }

        [HttpDelete]
        public ActionResult<Order> DeleteOrder(Order order)
        {
            try
            {
                _orderService.DeleteOrder(order);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost("UpdateOrder")]
        public ActionResult<Order> UpdateOrder(Order order)
        {
            try
            {
                var customerU = _orderService.UpdateOrder(order);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("CreateNewOrder")]
        public ActionResult<Order> CreateNewOrder(Order order)
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
