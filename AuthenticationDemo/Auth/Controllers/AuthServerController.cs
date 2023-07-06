using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class AuthSeverController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<AuthSeverController> _logger;

        public AuthSeverController(ILogger<AuthSeverController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAuthSever")]
        public IEnumerable<AuthSever> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new AuthSever
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}