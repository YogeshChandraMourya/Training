using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace UserService.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    //[Authorize]
    public class ValuesController : ControllerBase
    {
        public string GetToken()
        {
            var role=this.User.Claims.ToList().First();
            return DateTime.Now.ToString();
        }
    }
}
