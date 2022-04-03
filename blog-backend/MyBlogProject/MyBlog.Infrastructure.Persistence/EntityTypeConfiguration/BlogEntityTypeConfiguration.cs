using MyBlog.Domain.Entities;

namespace MyBlog.Infrastructure.Persistence.EntityTypeConfiguration
{
    internal class BlogEntityTypeConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(p => p.BlogId);

            builder.HasIndex(p => p.BlogName).IsUnique();

            builder.Property(p => p.BlogName).HasMaxLength(100).IsRequired();

        }
    }
}
