using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;

namespace TwitterClone.Infrastructure.Authentication
{
    public class JwtTokenService : ITokenService
    {
        public (string , DateOnly) GetToken( UserDto user)
        {
            return (string.Empty, DateOnly.MinValue);
        }
    }
}
