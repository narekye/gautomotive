using gAutomotive.WebApi.Common;
using System.Threading.Tasks;
using System.Web.Http;

namespace gAutomotive.WebApi.Controllers
{
    public class CustomerController : BaseApiController
    {
        public async Task<IHttpActionResult> GetAllCustomers()
        {
            await Task.WhenAll();
            return SuccessResponse(new object());
        }
    }
}
