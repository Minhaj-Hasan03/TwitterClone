using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Infrastructure.Persistence
{
    public class TwitterCloneDbContext : DbContext
    {
        public TwitterCloneDbContext(DbContextOptions<TwitterCloneDbContext> options):base(options)
        {

        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Tweet> Tweets => Set<Tweet>();
        public DbSet<Bookmark> Bookmarks => Set<Bookmark>();
        public DbSet<Follow> Follows => Set<Follow>();
        public DbSet<Like> Likes => Set<Like>();
        public DbSet<Message> Messages => Set<Message>();
        public DbSet<Notification> Notifications => Set<Notification>();
        public DbSet<LikeNotification> LikeNotifications { get; set; }
        public DbSet<CommentNotification> CommentNotifications { get; set; }
        public DbSet<FriendRequestNotification> FriendRequestNotifications { get; set; }
        public DbSet<MentionNotification> MentionNotifications { get; set; }
        public DbSet<SystemNotification> SystemNotifications { get; set; }



        public DbSet<Retweet> Retweets => Set<Retweet>();



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TwitterCloneDbContext).Assembly);
        }


    }
}
