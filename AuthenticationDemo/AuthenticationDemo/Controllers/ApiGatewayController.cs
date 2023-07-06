using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiGatewayController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ApiGatewayController> _logger;

        public ApiGatewayController(ILogger<ApiGatewayController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetApiGateway")]
        public IEnumerable<ApiGateway> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new ApiGateway
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}