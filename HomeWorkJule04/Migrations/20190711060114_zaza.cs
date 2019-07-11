using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWorkJule04.Migrations
{
    public partial class zaza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecentBlog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Heading = table.Column<string>(maxLength: 200, nullable: false),
                    Content = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentBlog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecentBlogContents",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 200, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    img = table.Column<string>(maxLength: 200, nullable: false),
                    Date = table.Column<DateTime>(maxLength: 200, nullable: false),
                    Question = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentBlogContents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecentBlog");

            migrationBuilder.DropTable(
                name: "RecentBlogContents");
        }
    }
}
