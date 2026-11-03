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
    public class FollowConfiguration : IEntityTypeConfiguration<Follow>
    {
        public void Configure(EntityTypeBuilder<Follow> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property( e=> e.FollowerId ).IsRequired();
            builder.Property( e => e.FollowingId ).IsRequired();


            builder.HasOne<User>().WithMany().HasForeignKey(u => u.FollowerId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<User>().WithMany().HasForeignKey(u => u.FollowingId).OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(e => new { e.FollowerId, e.FollowingId }).IsUnique();


            builder.ToTable(e => e.HasCheckConstraint(
                    "CK_Follow_NoSelfFollow",
                    "\"FollowerId\" <> \"FollowingId\""
                ));
        }
    }
}
