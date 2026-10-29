using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Interfaces;

namespace TwitterClone.Infrastructure.Authentication
{
    public class PasswordHasher : IPasswordHasher
    {
        public bool VerifyPassword(string password, string passwordHash)
        {
            return true;
        }
    }
}
