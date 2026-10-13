using Microsoft.AspNetCore.Mvc;

using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;
using TwitterClone.Application.Dtos;
namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly ITweetService _tweetService;
        public TweetsController( ITweetService tweetService)
        {
            _tweetService = tweetService;
        }


        // GET /api/tweets?userId={userId}
        [HttpGet]
        public IActionResult GetTweets([FromQuery] Guid? userId)
        {
            return Ok(_tweetService.GetTweets(userId));
        }

        // GET /api/tweets/{id}
        [HttpGet("{id}")]
        public IActionResult GetTweetById([FromRoute] Guid id)
        {
            var tweet = _tweetService.GetTweetById(id);

            if (tweet == null)
            {
                return NotFound();
            }

            return Ok(tweet);
        }


        // POST /api/tweets
        [HttpPost]
        public IActionResult CreateTweet([FromBody] CreateTweetDto createTweetDto)
        {
            var createdTweet = _tweetService.CreateTweet(createTweetDto);

            if (createdTweet is null)
            {
                return BadRequest("Invalid content or user not found.");
            }

            return Ok(new TweetDto
            {
                Id = createdTweet.Id,
                UserId = createdTweet.UserId,
                Content = createdTweet.Content,
                CreatedAt = createdTweet.CreatedAt,
            });
        }

        // PUT /api/tweets/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute] Guid id, [FromBody] UpdateTweetDto updateTweetDto)
        {
            var updatedTweet = _tweetService.UpdateTweet(id, updateTweetDto);

            if (updatedTweet is null)
            {
                return NotFound("Tweet Not found or Content is invalid");
            }

            return Ok(updatedTweet);
        }


        // DELETE /api/tweets/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute] Guid id)
        {
            var isDeleted = _tweetService.DeleteTweet(id);

            if (isDeleted == false)
            {
                return NotFound();
            }

            return Ok(isDeleted);
        }
    }
}
