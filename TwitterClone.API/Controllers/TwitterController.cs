using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase
    {
        private readonly IConfiguration _configeration;
        public TwitterController(IConfiguration configuration)
        {
            _configeration = configuration; 
        }

        /*
        public void GetTweet()
        {
            var connectionString = _configeration.GetValue<string>("Logging: LogLevel: Default");
        }
        */

        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = new List<Tweet>
            {
                new Tweet(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), "This is a sample tweet."),
                new Tweet(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), "Another sample tweet."),
            };

            int maxTweetLength = _configeration.GetValue<int>("TwitterSettings:MaxTweetLength");

           return Ok(new
           {
               Tweets = tweets,
               MaxTweetLength = maxTweetLength
           });
        }
    }
}
