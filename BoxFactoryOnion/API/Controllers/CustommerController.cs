using Application.DTOs;
using Application.Interface.ICustomer;
using Domain.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustommerController : ControllerBase
    {
        private ICustomerService _customerService;
        public CustommerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public List<GetCustomerDTO> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }

        [HttpDelete]
        public ActionResult<Customer> DeleteCustomer(Customer customer)
        {
            try
            {
                _customerService.DeleteCustomer(customer);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost("UpdateCustomer")]
        public ActionResult<Customer> UpdateCustomer(Customer customer)
        {
            try
            {
                var customerU = _customerService.UpdateCustomer(customer);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("CreateNewCustomer")]
        public ActionResult<Customer> CreateNewCustomer(Customer customer)
        {
            try
            {
                var result = _customerService.CreateNewCustomer(customer);
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
