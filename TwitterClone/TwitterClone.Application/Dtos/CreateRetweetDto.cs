using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Application.Dtos
{
    public class CreateRetweetDto : IValidatableObject
    {
        public required Guid UserId { get; set; }
        public required Guid TweetId { get; set; }

        
        public string? Comment { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return RetweetCommentValidator.Validate(Comment, nameof(Comment));
        }
    }
}
