using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Code_Community.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForumUsers",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    Username = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(maxLength: 500, nullable: false),
                    AvatarUrl = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: false),
                    Member_Since = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    PostTitle = table.Column<string>(maxLength: 500, nullable: false),
                    PostMessage = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumUsers");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
