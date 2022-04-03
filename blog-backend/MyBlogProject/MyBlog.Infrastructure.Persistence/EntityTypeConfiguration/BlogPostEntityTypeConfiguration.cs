using MyBlog.Domain.Entities;

namespace MyBlog.Infrastructure.Persistence.EntityTypeConfiguration
{
    internal class BlogPostEntityTypeConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasKey(p => p.BlogPostId);

            builder.Property(p => p.Content).HasMaxLength(2000).IsRequired();

        }
    }
}
