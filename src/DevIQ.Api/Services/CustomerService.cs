using AutoMapper;
using DevIQ.Api.Interfaces;
using DevIQ.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevIQ.Core.Specifications;
using DevIQ.Core.Interfaces;
using DevIQ.Core.Entities;
using Ardalis.GuardClauses;
using DevIQ.Core.Specifications.Filters;

namespace DevIQ.Api.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Customer> customerRepository;

        public CustomerService(IMapper mapper,  
                                 IRepository<Customer> customerRepository)
        {
            this.mapper = mapper;
            this.customerRepository = customerRepository;
        }


        // Here I'm just writing various usages, not necessarilly you'll need all of them.

        public async Task<CustomerModel> GetCustomer(int customerId)
        {
            var customer = await customerRepository.GetByIdAsync(customerId);

            Guard.Against.Null(customer, nameof(customer));

            return mapper.Map<CustomerModel>(customer);
        }

        public async Task<CustomerModel> GetCustomer(string customerName)
        {
            var customer = await customerRepository.GetBySpecAsync(new CustomerByNameSpec(customerName));

            Guard.Against.Null(customer, nameof(customer));

            return mapper.Map<CustomerModel>(customer);
        }

        public async Task<CustomerModel> GetCustomerWithStores(string customerName)
        {
            var customer = await customerRepository.GetBySpecAsync(new CustomerByNameWithStoresSpec(customerName));

            Guard.Against.Null(customer, nameof(customer));

            return mapper.Map<CustomerModel>(customer);
        }

        public async Task<List<CustomerModel>> GetCustomers(CustomerFilterModel filterDto)
        {
            var spec = new CustomerSpec(mapper.Map<CustomerFilter>(filterDto));
            var customers = await customerRepository.ListAsync(spec);

            return mapper.Map<List<CustomerModel>>(customers);
        }

        
    }
}