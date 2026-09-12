using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IConfiguration _configuration;
        public UserController( IConfiguration configuration ) {


            _configuration = configuration;
        }



        [HttpPost]
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
    }
}
