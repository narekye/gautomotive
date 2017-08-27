using System.Collections.Generic;
using gAutomotive.WebApi.Common;
using System.Threading.Tasks;
using System.Web.Http;
using gAutomotive.DAL;

namespace gAutomotive.WebApi.Controllers
{
    public class CustomerController : BaseApiController
    {
        public async Task<IHttpActionResult> GetAllCustomers()
        {
            var result = await this.Dal.GetAllCustomersAsync();
            return SuccessResponse<IEnumerable<Customer>>(result);
        }

        public async Task<IHttpActionResult> AddCustomer(Customer customer)
        {
            await this.Dal.AddCustomer(customer);
            return SuccessResponse(new object());
        }

        public async Task<IHttpActionResult> GetCustomerByPhone(string number)
        {
            await Task.WhenAll();
            return this.Ok();
        }

        public async Task<IHttpActionResult> GetCustomerByName(string name)
        {
            await Task.WhenAll();
            return this.Ok();
        }
    }
}
