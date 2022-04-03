using MyBlog.Domain.Entities;

namespace MyBlog.Infrastructure.Persistence.Context
{
    internal interface IMyBlogDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Blog> Blogs { get; }
        DbSet<BlogPost> BlogPosts { get; }
    }
}
