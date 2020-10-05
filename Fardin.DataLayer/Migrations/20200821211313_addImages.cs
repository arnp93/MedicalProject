using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class addImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "subPosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "subPostDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "subPostId",
                table: "imageGalleries",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images",
                table: "subPosts");

            migrationBuilder.DropColumn(
                name: "Images",
                table: "subPostDescriptions");

            migrationBuilder.DropColumn(
                name: "subPostId",
                table: "imageGalleries");
        }
    }
}
