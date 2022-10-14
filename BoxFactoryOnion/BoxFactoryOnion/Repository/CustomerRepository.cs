using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface;
using Application.Interface.ICustomer;

namespace Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer CreateNewCustomer(Customer customer)
        {
            return customer;
        }

        public List<Customer> GetAllCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){ Id = 1, Name="Frank", LastName="Frank", CompanyName="FrankINC", EMail="frank@frankinc.com", PhoneNumber=23458217},
                new Customer(){ Id = 2, Name="Jucam", LastName="VonAnd", CompanyName="EcoLogi", EMail="juand@ecologi.com", PhoneNumber=22802320},
                new Customer(){ Id = 3, Name="Alex", LastName="Andy", CompanyName="Andy's", EMail="aa@andysfood.com", PhoneNumber=97392929},
            };
        }
    }
}
