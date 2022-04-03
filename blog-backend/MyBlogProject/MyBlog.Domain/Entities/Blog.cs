namespace MyBlog.Domain.Entities
{
    public class Blog : TimeTrackebleEntity
    {
        public Guid BlogId { get; set; }
        public Guid BlogAuthorId { get; set; }
        public string BlogName { get; set; }
        public string Description { get; set; }

        public virtual User Author { get; set; }
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
    }
}
