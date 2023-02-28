using Microsoft.AspNetCore.Mvc;

namespace TestJenkins.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            int summ = 0;
            var x = sum(1, 2,ref summ);

            return  Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        private bool sum(int x , int y , ref int summ)
        {

            summ = x + y;
            return true;

        }
        [HttpGet("GetMessage")]
        public ActionResult<string> Message()
        {
           

            return Ok("Ahmed");
        }

        [HttpGet("TestPipeLine")]
        public ActionResult<string> PipeLine()
        {


            return Ok("It Works");
        }

        [HttpGet("TestPipeLine3")]
        public ActionResult<string> PipeLine3()
        {


            return Ok("It Works3");
        }
      
    }
}