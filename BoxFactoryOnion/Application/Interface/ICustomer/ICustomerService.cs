using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Entities;

namespace Application.Interface.ICustomer
{
    public interface ICustomerService
    {
        public Customer CreateNewCustomer(Customer customer);
        public List<GetCustomerDTO> GetAllCustomers();
        public Customer UpdateCustomer(Customer customer);
        public void DeleteCustomer(Customer customer);
    }
}
