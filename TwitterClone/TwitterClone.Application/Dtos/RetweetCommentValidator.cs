using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Dtos
{
    internal static class RetweetCommentValidator
    {
        public static IEnumerable<ValidationResult> Validate(string? comment, string memberName)
        {
            if (comment != null && comment.Length > Tweet.MaxContentLength)
            {
                yield return new ValidationResult(
                    $"Retweet comment cannot be longer than {Tweet.MaxContentLength} characters.",
                    new[] { memberName });
            }
        }
    }
}
