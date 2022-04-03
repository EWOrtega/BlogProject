using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Infrastructure.Persistence.Migrations
{
    public partial class blogschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "blog");

            migrationBuilder.RenameTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users",
                newName: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users",
                newSchema: "blog");

            migrationBuilder.RenameTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs",
                newName: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs",
                newSchema: "blog");

            migrationBuilder.RenameTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts",
                newName: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts",
                newSchema: "blog");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users",
                schema: "blog",
                newName: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users");

            migrationBuilder.RenameTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs",
                schema: "blog",
                newName: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs");

            migrationBuilder.RenameTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts",
                schema: "blog",
                newName: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts");
        }
    }
}
