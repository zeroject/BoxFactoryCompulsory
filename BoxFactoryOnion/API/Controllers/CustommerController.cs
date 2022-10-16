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
        public List<Customer> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }

        [HttpPost]
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
