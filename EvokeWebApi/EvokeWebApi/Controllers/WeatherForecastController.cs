using EvokeWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvokeWebApi.Controllers
{
    [ApiController]
    [Route("school/books/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        static List<string> names = new List<string>();

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ITimer _timer;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, ITimer timerclass)
        {
            _timer = timerclass;
            _logger = logger;
        }





        [HttpGet(template: "GetWeatherForecast")]
        public IEnumerable<String> Get(/*[FromQuery] int n*/)
        {
            return names;
        }

        [HttpPost]

        public IActionResult Post(string name)
        {
            names.Add(name);
            return Ok(names);
        }
        [HttpPut]
        public IActionResult Put(string name, string newName)
        {
            if (names.Count > 0)
            {
                int index = names.FindIndex(n => n.Equals(name));
                names[index] = newName;
            }
            else
            {
                return BadRequest("Name is Empty");
            }
            return Ok();


        }
        [HttpDelete]
        public IActionResult Delete(string name)
        {
            if (names.Count > 0)
            {
                int index = names.FindIndex(n => n.Equals(name));
                if (index >= 0)
                {
                    names.Remove(name);
                    return Ok("Record Deleted");
                }
            }
            return NotFound("Name doesn't exist in collection");
            //return NoContent();


        }
    }
}