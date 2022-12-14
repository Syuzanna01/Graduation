using DataAccessLayer.Entities;
using Graduation.BLL.BLConract;
using Microsoft.AspNetCore.Mvc;

namespace Graduation.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IGroupBL _groupBL;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IGroupBL groupBL)
        {
            _logger = logger;
            _groupBL = groupBL;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get(int id)//[FromBody] GroupEntity groupEntity
        {
            _groupBL.GetById(id);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}