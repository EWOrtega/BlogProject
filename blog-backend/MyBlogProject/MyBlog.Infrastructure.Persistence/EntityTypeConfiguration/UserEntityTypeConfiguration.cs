using MyBlog.Domain.Entities;

namespace MyBlog.Infrastructure.Persistence.EntityTypeConfiguration
{
    internal class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.UserId);

            builder.HasIndex(p => p.UserName).IsUnique();

            builder.Property(p => p.UserName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.EmailAdress).HasMaxLength(255).IsRequired();

        }
    }
}
