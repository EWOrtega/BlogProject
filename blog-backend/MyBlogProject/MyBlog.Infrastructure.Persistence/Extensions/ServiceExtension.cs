using MyBlog.Domain.Repositories;
using MyBlog.Infrastructure.Persistence.Context;
using MyBlog.Infrastructure.Persistence.Repository;

namespace MyBlog.Infrastructure.Persistence.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<IMyBlogDbContext, MyBlogDbContext>(options => options.UseSqlServer(connectionString));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IBlogPostRepository, BlogPostRepository>();
            services.AddTransient<IBlogRepository, BlogRepository>();
            return services;
        }
    }
}
