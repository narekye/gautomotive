using gAutomotive.WebApi.Models;
using System.Web.Http;
using System.Web.Http.Results;
using gAutomotive.DAL.Repository;

namespace gAutomotive.WebApi.Common
{
    public abstract class BaseApiController : ApiController
    {
        protected IGAutomotive Dal;

        public BaseApiController()
        {
            this.Dal = new GAutomotive();
        }
        public virtual IHttpActionResult SuccessResponse<T>(T data = null) where T : class
        {
            return Ok(new ResponseModel<T> { Data = data, IsSuccess = true });
        }

        public virtual IHttpActionResult ExcepctionResponse(HttpResponseException e)
        {
            return this.Ok(new ResponseModel<object> { Data = null, IsSuccess = false });
        }
    }
}
