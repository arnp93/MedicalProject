using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class fixCommentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "isComment",
                table: "comments");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "comments",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "comments",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "comments",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isComment",
                table: "comments",
                nullable: false,
                defaultValue: false);
        }
    }
}
