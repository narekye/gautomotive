using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using gAutomotive.DAL.Repository.Core;

namespace gAutomotive.DAL.Repository
{
    public class GAutomotive : BaseGAutomotiveDAL, IGAutomotive
    {
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await Database.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerById(long id)
        {
            var customer = await Database.Customers.FirstOrDefaultAsync(x => x.Id == id);
            return customer;
        }

        public Task AddCustomer(Customer customer)
        {
            Database.Customers.Add(customer);
            return SaveChanges();
        }
    }
}
