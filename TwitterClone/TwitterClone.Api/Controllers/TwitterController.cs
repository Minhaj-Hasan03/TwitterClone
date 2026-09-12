using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase //for acessing appsetting.json we need the controller 
    {
        private readonly IConfiguration _configuration;
        public TwitterController( IConfiguration configuration ) 
        {
            _configuration = configuration;

        }

        //public void GetTweet()
        //{
        //    var connectionString = _configuration.GetValue<string>("Logging:LogLevel:Default");
        //}


        [HttpGet]
        public IActionResult GetTweets()
        {

            string? maxLength = _configuration.GetValue<string>("TwitterSettings:MaxTweetLength");

            var tweets = new List<object>
            {
                new 
                {
                    UserId = Guid.NewGuid(),
                    Content = "hi!",
                },
                new 
                {
                    UserId = Guid.NewGuid(),
                    Content = "hi! my second tweet",
                }
            };
            return Ok(new{ tweets, maxLength} );
        }
    }
}
