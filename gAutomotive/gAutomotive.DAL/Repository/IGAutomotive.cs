using System.Collections.Generic;
using System.Threading.Tasks;

namespace gAutomotive.DAL.Repository
{
    public interface IGAutomotive
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerById(long id);
        Task AddCustomer(Customer customer);
    }
}