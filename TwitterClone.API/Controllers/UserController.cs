using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<User>
            {
                new User("Md Inkul", "Azla Hasan", "mdinkul@example.com"),
                new User("MH", "Sakib", "mh.sakib@example.com"),
                new User("Al-Amin","Oyon", "al-amin.oyon2example.com"),
            };

            return Ok(users);
        }
    }
}
