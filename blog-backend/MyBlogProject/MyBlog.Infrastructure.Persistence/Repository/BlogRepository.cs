using MyBlog.Domain.Repositories;
using MyBlog.Infrastructure.Persistence.Context;

namespace MyBlog.Infrastructure.Persistence.Repository
{
    internal class BlogRepository : IBlogRepository
    {
        private readonly IMyBlogDbContext context;

        public BlogRepository(IMyBlogDbContext context)
        {
            this.context = context;
        }
    }
}
