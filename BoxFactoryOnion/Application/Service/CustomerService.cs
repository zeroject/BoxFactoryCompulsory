using Application.DTOs;
using Application.Interface.IBox;
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

        public void DeleteCustomer(Customer customer)
        {
            _customerRepository.DeleteCustomer(customer);
        }

        public List<GetCustomerDTO> GetAllCustomers()
        {
            List<Customer> customers = _customerRepository.GetAllCustomers();
            List<GetCustomerDTO> getCustomerDTOs = new List<GetCustomerDTO>();
            foreach (var item in customers)
            {
                var temp = new GetCustomerDTO { CompanyName = item.CompanyName, LastName = item.LastName, Name = item.Name};
                getCustomerDTOs.Add(temp);
            }
            return getCustomerDTOs;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }
    }
}
