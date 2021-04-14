using Microsoft.AspNetCore.Mvc;
using DevIQ.Api.Interfaces;
using DevIQ.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIQ.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        [HttpGet("{Id}")]
        public Task<CustomerModel> Get(int Id)
        {
            return _customerService.GetCustomer(Id);
        }

        [HttpGet("{name}")]
        public Task<CustomerModel> Get(string name)
        {
            return _customerService.GetCustomer(name);
        }

        [HttpGet]
        public Task<List<CustomerModel>> Get([FromQuery] CustomerFilterModel filter)
        {
            filter = filter ?? new CustomerFilterModel();

            // Here you can decide if you want the collections as well

            filter.LoadChildren = true;
            filter.IsPagingEnabled = true;

            return _customerService.GetCustomers(filter);
        }
    }
}