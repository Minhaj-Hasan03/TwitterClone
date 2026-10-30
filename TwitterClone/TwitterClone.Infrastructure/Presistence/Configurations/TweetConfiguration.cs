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
    public class TweetConfiguration : IEntityTypeConfiguration<Tweet>
    {
       
        public void Configure(EntityTypeBuilder<Tweet> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.UserId)
                .IsRequired();

            builder.Property(t => t.Content)
                .HasMaxLength(Tweet.MaxContentLength)
                .IsRequired();

           
            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasIndex(t => t.UserId);
        }
    }
}
