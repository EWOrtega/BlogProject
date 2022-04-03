namespace MyBlog.Domain.Entities
{
    public class User : TimeTrackebleEntity
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }

    }
}
