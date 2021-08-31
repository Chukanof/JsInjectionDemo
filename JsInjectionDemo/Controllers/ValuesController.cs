using System.Web.Http;

namespace JsInjectionDemo.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("count")]
        public IHttpActionResult Get(int value)
        {
            return Ok(value);
        }
    }
}
