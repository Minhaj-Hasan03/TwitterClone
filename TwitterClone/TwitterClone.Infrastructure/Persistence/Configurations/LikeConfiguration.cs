using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Infrastructure.Presistence.Configurations
{
    public class LikeConfiguration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.UserId).IsRequired();
            builder.Property(u => u.TweetId).IsRequired();

            builder.HasOne<User>().WithMany().HasForeignKey(u => u.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Tweet>().WithMany().HasForeignKey(u => u.TweetId).OnDelete(DeleteBehavior.Cascade);


            builder.HasIndex(x => new { x.UserId, x.TweetId }).IsUnique();


            

        }
    }
}
