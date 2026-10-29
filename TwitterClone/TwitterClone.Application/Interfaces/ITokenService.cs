using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Interfaces
{
    public interface ITokenService
    {
        (string, DateOnly) GetToken(UserDto user);
    }
}
