using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreFormsDockerNginx.Controllers
{
    [Route("api/values")]
    public class ValuesController : Controller
    {
        public ActionResult Post([FromBody]string[] test)
        {
             return new JsonResult(test);
        }
    }
}