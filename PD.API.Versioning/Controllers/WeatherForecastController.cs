using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace PD.API.Versioning.Controllers
{

    [ApiController]
    [ApiVersion(1.0)]
    [ApiVersion(2.0)]
    [Route("v{version:apiVersion}/weather")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[] { "V1" };

        private static readonly string[] Summariesv2 = new[] { "V2" };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet, MapToApiVersion(2.0)]
        public IEnumerable<WeatherForecast> Getv2()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summariesv2[Random.Shared.Next(Summariesv2.Length)]
            })
            .ToArray();
        }
    }
}