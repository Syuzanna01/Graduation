using DataAccessLayer.Entities;
using Graduation.BLL.BLConract;
using Graduation.BLL.Maper;
using Microsoft.AspNetCore.Mvc;

namespace Graduation.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IGroupBL _groupBL;
        private readonly IStudentBL _studentBL;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IGroupBL groupBL,IStudentBL studentBL)
        {
            _logger = logger;
            _groupBL = groupBL;
            _studentBL = studentBL;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get(int Id)//[FromBody] GroupEntity groupEntity
        {
            _groupBL.GetById(Id);

            return Ok();
        }

        [HttpPost]
        public void Save([FromBody] StudentsModel student)//[FromBody] GroupEntity groupEntity
        {
            _studentBL.Insert(student);
        }   
    }
}