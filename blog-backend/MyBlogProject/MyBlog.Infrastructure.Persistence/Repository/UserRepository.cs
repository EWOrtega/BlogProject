using MyBlog.Domain.Repositories;
using MyBlog.Infrastructure.Persistence.Context;

namespace MyBlog.Infrastructure.Persistence.Repository
{
    internal class UserRepository : IUserRepository
    {
        private readonly IMyBlogDbContext context;

        public UserRepository( IMyBlogDbContext context)
        {
            this.context = context;
        }

    }
}
