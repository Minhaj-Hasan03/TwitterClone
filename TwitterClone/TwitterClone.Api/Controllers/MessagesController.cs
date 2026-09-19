using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{

    [Route("api/[controller]")]
    [Controller]
    public class MessagesController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetMessage([FromRoute] Guid id  )
        {

            return Ok(new
            {
                sender_id = Guid.NewGuid()

            });
        }
    }
}
