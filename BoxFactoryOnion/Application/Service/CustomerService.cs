using Application.DTOs;
using Application.Interface.ICustomer;
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
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;
        private IMapper _mapper;
        private IValidator<GetCustomerDTO> _getValidator;
        public CustomerService(ICustomerRepository repository, IMapper mapper, IValidator<GetCustomerDTO> validator)
        {
            _customerRepository = repository;
            _mapper = mapper;
            _getValidator = validator;
        }

        public Customer CreateNewCustomer(Customer customer)
        {
            return _customerRepository.CreateNewCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }
    }
}
