namespace MyBlog.Domain.Entities
{
    public class BlogPost : TimeTrackebleEntity
    {
        public Guid BlogPostId { get; set; }
        public Guid AuthorUserId { get; set; }
        public string Content { get; set; }
        public virtual User Author { get; set; }
    }
}
