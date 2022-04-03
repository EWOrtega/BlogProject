using MyBlog.Domain.Repositories;
using MyBlog.Infrastructure.Persistence.Context;

namespace MyBlog.Infrastructure.Persistence.Repository
{
    internal class BlogPostRepository : IBlogPostRepository
    {
        private readonly IMyBlogDbContext context;

        public BlogPostRepository(IMyBlogDbContext context)
        {
            this.context = context;
        }
    }
}
