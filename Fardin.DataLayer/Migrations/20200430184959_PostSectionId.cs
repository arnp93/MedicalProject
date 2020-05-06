using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class PostSectionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "posts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "posts");
        }
    }
}
