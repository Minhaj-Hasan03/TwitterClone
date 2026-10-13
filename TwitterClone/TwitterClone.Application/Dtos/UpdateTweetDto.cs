using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Application.Dtos
{
    public class UpdateTweetDto
    {
        [Required]
        public required string Content { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return TweetContentValidator.Validate(Content, nameof(Content));
        }
    }
}
