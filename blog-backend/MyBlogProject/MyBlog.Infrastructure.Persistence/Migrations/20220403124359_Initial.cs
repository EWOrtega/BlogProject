using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Infrastructure.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAdress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs",
                columns: table => new
                {
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogAuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.~",
                        column: x => x.AuthorUserId,
                        principalTable: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts",
                columns: table => new
                {
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts", x => x.BlogPostId);
                    table.ForeignKey(
                        name: "FK_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbCon~1",
                        column: x => x.BlogId,
                        principalTable: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs",
                        principalColumn: "BlogId");
                    table.ForeignKey(
                        name: "FK_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbCont~",
                        column: x => x.AuthorUserId,
                        principalTable: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts_AuthorUserId",
                table: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts",
                column: "AuthorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts_BlogId",
                table: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs_AuthorUserId",
                table: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs",
                column: "AuthorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs_BlogName",
                table: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs",
                column: "BlogName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users_UserName",
                table: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.BlogPosts");

            migrationBuilder.DropTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Blogs");

            migrationBuilder.DropTable(
                name: "MyBlog.Infrastructure.Persistence.Context.IMyBlogDbContext.Users");
        }
    }
}
