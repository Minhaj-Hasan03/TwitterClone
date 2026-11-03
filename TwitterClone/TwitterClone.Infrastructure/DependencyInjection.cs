using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TwitterClone.Application.Interfaces;

using TwitterClone.Infrastructure.Authentication;
using TwitterClone.Infrastructure.Persistence;
using TwitterClone.Infrastructure.Repositories;

namespace TwitterClone.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure( this IServiceCollection services, IConfiguration
             configuration )
        {
            //singleton because the repositroies keep their data in memory

            //switch to scoped when they are backed by real database 

            //objecct life time 1.singleton, 2.scoped, 3. transit
            var connectionString = configuration.GetConnectionString("TwitterCloneDb");
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new Exception("Database connection string is not found");
            }


            services.AddDbContext<TwitterCloneDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITweetRepository, TweetRepository>();
            services.AddScoped<IBookmarkRepository, BookmarkRepository>();
            services.AddScoped<IFollowRepository, FollowRepository>();
            services.AddScoped<ILikeRepository, LikeRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IRetweetRepository, RetweetRepository>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<ITokenService, JwtTokenService>();


            return services;
        }
    }
}
