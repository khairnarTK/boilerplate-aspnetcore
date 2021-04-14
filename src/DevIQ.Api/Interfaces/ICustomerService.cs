using System.Collections.Generic;
using System.Threading.Tasks;
using DevIQ.Api.Models;

namespace DevIQ.Api.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerModel> GetCustomer(int customerId);
        Task<CustomerModel> GetCustomer(string customerName);
        Task<CustomerModel> GetCustomerWithStores(string customerName);

        Task<List<CustomerModel>> GetCustomers(CustomerFilterModel filterDto);
    }
}