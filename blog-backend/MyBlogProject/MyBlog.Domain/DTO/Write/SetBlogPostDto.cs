namespace MyBlog.Domain.DTO.Write
{
    public record SetBlogPostDto(Guid AuthorUserId, string Content);
}
