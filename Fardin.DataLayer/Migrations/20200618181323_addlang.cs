using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class addlang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LanguageTitle",
                table: "subPosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LanguageTitle",
                table: "subPostDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LanguageTitle",
                table: "posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageTitle",
                table: "subPosts");

            migrationBuilder.DropColumn(
                name: "LanguageTitle",
                table: "subPostDescriptions");

            migrationBuilder.DropColumn(
                name: "LanguageTitle",
                table: "posts");
        }
    }
}
