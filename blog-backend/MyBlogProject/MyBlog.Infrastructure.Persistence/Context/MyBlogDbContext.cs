using MyBlog.Domain.Entities;

namespace MyBlog.Infrastructure.Persistence.Context
{
    internal class MyBlogDbContext : DbContext, IMyBlogDbContext
    {
        public MyBlogDbContext(DbContextOptions<MyBlogDbContext> options) : base(options)
        { }

        DbSet<User> IMyBlogDbContext.Users { get; }
        DbSet<Blog> IMyBlogDbContext.Blogs { get; }
        DbSet<BlogPost> IMyBlogDbContext.BlogPosts { get; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("blog");
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public MyBlogDbContext()
        {

        }
    }
}
