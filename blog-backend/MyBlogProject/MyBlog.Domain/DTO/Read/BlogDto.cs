using MyBlog.Domain.Entities;

namespace MyBlog.Domain.DTO.Read
{
    public record BlogDto(Guid BlogId, UserDto Author, string Description, ICollection<BlogPost> BlogPosts);
}
