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
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.Id);


            builder.Property( x => x.SenderId ).IsRequired();
            builder.Property(x => x.ReceiverId).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(500).IsRequired();
            builder.Property(x => x.IsRead).HasDefaultValue(false).IsRequired();
            builder.Property(x => x.SentAt).IsRequired();


            builder.HasOne<User>().WithMany().HasForeignKey(x => x.SenderId).OnDelete(DeleteBehavior.Restrict);

         
            builder.HasOne<User>().WithMany().HasForeignKey(x => x.ReceiverId).OnDelete(DeleteBehavior.Restrict);


            builder.HasIndex(m => new
            {
                m.SenderId,
                m.ReceiverId,
                m.SentAt
            }).IsUnique();


            builder.ToTable(x => x.HasCheckConstraint(
                    "CK_Message_NoSelfMessage",
                    "\"SenderId\" <> \"ReceiverId\""
                ));
        }
    }
}
