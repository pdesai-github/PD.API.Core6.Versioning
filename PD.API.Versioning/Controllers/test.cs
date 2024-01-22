using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace PD.API.Versioning.Controllers
{
    [ApiController]
    [ApiVersion(1.0)]
    [Route("api/v{version:apiVersion}/test")]
    public class test : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "V1";
        }
    }
}
