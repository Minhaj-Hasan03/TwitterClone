using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;
using TwitterClone.Application.Mappings;


namespace TwitterClone.Application.Services
{
    public class AuthService :IAuthService
    {
        private readonly ITokenService _tokenService;
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;


        public AuthService( IUserRepository userRepository
            , ITokenService tokenService, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _tokenService = tokenService; 
            _passwordHasher = passwordHasher;
        }

       


        public AuthResponseDto? Login(LoginDto loginDto)
        {
            var user = _userRepository.GetUserByEmail(loginDto.Email);

            var userAuthorized = _passwordHasher.VerifyPassword(user.ToDto()  ,loginDto.Password, user.PasswordHash );


            if( userAuthorized)
            {
                var (token, expiryTime) = _tokenService.GetToken(user.ToDto());

                return new AuthResponseDto
                {
                    AccessToken = token,
                    ExpiresAt = expiryTime,
                    UserDto = user.ToDto()
                };
            }
            return null ;
        }

        

    }
}
