using System.Web.Http;
using gAutomotive.DAL.Repository;

namespace gAutomotive.WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        // public IGAutomotive GAutomotive { get; set; }
        public CustomerController()
        {
            // GAutomotive = automotive;
        }

        public IHttpActionResult Get()
        {
            // GAutomotive.GetAllCustomersAsync();
            return this.Ok();
        }
    }
}
