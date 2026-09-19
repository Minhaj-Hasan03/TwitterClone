using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {

        // /api/likes/id/like
        [HttpPut( "{id}/like")]
        public IActionResult LikeByUserId([FromRoute] Guid userId)
        {
            return Ok();
        }
    }
}
