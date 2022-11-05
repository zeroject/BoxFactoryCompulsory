using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface;
using Application.Interface.ICustomer;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private DbContextOptions<DBContext> _dbContextOptions;
        public CustomerRepository()
        {
            _dbContextOptions = new DbContextOptionsBuilder<DBContext>()
                .UseSqlServer("").Options;
        }
        public Customer CreateNewCustomer(Customer customer)
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(Customer customer)
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            return context.Customers.ToList();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            context.Customers.Update(customer);
            context.SaveChanges();
            return customer;
        }
    }
}
