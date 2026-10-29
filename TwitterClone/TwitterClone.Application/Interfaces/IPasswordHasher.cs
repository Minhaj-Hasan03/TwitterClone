using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Interfaces
{
    public interface IPasswordHasher
    {
        
        bool VerifyPassword( string password, string passwordHash);
    }
}
