using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class addTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostTitle",
                table: "postDetails",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "posts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "postDetails",
                newName: "PostTitle");
        }
    }
}
