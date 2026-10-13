using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]



    //[Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService) // Dependency Injection
        {
            _userService = userService;
        }


        // /api/users
        [HttpGet]
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
        }

        // /api/users
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser([FromBody] CreateUserDto createUserDto)
        {
            var createdUser = _userService.CreateUser(createUserDto);

            if (createdUser == null)
            {
                return BadRequest("An Error happened during create user.");
            }

            return Ok(new UserDto
            {
                Id = createdUser.Id,
                FirstName = createdUser.FirstName,
                LastName = createdUser.LastName,
                Email = createdUser.Email
            });
        }


        // /api/users/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
            var user = _userService.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT /api/users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserDto updateUserDto)
        {
            var user = _userService.UpdateUser(id, updateUserDto);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }


        // PATCH /api/users/{id}/phoneNumber
        [HttpPatch("{id}/phoneNumber")]
        public IActionResult UpdateUserPhoneNumber([FromRoute] Guid id, [FromBody] string phoneNumber)
        {
            return Ok("hello");

        }

        // DELETE /api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            var isDeleted = _userService.DeleteUser(id);

            if (isDeleted == false)
            {
                return NotFound();
            }

            return Ok(isDeleted);
        }
    }
}
