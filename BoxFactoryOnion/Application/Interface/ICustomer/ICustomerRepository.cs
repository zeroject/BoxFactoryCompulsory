using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interface.ICustomer
{
    public interface ICustomerRepository
    {
        public Customer CreateNewCustomer(Customer customer);
        public List<Customer> GetAllCustomers();
        public Customer UpdateCustomer(Customer customer);
        public void DeleteCustomer(Customer customer);
    }
}
