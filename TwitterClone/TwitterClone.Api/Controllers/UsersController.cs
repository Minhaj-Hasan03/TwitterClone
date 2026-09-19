using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        public readonly IConfiguration _configuration;
        public UsersController( IConfiguration configuration ) {


            _configuration = configuration;
        }


        // /api/users 
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser()
        {

            var user = new List<object>
            {
                new 
                {
                    UserId = Guid.NewGuid(),
                    FirstName = "Minhaj",
                    LastName = "Hasan",
                    Email = "hasan0@gamil.com",
                    UserName = "Minhaj_Hasan_2003"
                },


                new
                {
                    UserId = Guid.NewGuid(),
                    FirstName = "Mahadin",
                    LastName = "Hasan",
                    Email = "mahadin@gamil.com",
                    UserName = "mahadin_0505"
                },
                


                new
                {
                    UserId = Guid.NewGuid(),
                    FirstName = "Sabbir",
                    LastName = "Islam",
                    Email = "sabbirtechno@gamil.com",
                    UserName = "sabbirfero2009@gmail.com"
                }
            };

            return Ok(user);
        }



        //  /api/users/id/follow
        [HttpPost("{id}/follow")]
        public IActionResult Follow([FromRoute] Guid userId )
        {
            return Ok("the users is followed");
        }


        // /api/users/id/unfollow
        [HttpPost("{id}/unfollow")]
        
        public IActionResult UnFollow([FromRoute] Guid userId)
        {
            return Ok("the users is unfollowed");
        }
    }
}
