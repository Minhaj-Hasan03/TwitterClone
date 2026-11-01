using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Application.Dtos
{
    public class LoginDto
    {
        [EmailAddress]
        [Required]
        public required string Email     { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}
