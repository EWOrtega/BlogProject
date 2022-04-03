namespace MyBlog.Domain.DTO.Read
{
    public record BlogPostDto(Guid BlogPostId, string Content, UserDto Author);
}
