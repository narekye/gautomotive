using gAutomotive.WebApi.Models;
using System.Web.Http;
using System.Web.Http.Results;

namespace gAutomotive.WebApi.Common
{
    public abstract class BaseApiController : ApiController
    {
        public virtual IHttpActionResult SuccessResponse<T>(T data = null) where T : class
        {
            return Ok(new ResponseModel<T> { Data = data, HasError = false });
        }

        public virtual IHttpActionResult ExcepctionResponse(HttpResponseException e)
        {
            return new BadRequestErrorMessageResult("Something went wrong", this);
        }
    }
}
