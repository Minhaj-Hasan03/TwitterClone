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
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.UserId)
                .IsRequired();

            builder.Property(n => n.NotificationType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(n => n.IsRead)
                .IsRequired()
                .HasDefaultValue(false);


            builder.Property<string>("_message")
                .HasField("_message")
                .HasColumnName("Message")
                .HasMaxLength(500)
                .IsRequired();


            builder.HasOne<User>()
               .WithMany()
               .HasForeignKey(n => n.UserId)
               .OnDelete(DeleteBehavior.Cascade);

           
            builder.HasIndex(n =>  n.UserId);

        }
    }
}
