using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace PD.API.Versioning.Controllers
{
    [ApiController]
    [ApiVersion(2.0)]
    [Route("api/v{version:apiVersion}/test")]
    public class test2 : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "V2";
        }
    }
}
