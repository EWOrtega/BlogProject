namespace MyBlog.Domain.Entities
{
    public class TimeTrackebleEntity
    {
        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
    }
}
