using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language_Id",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "languageName",
                table: "posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Language_Id",
                table: "posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "languageName",
                table: "posts",
                nullable: true);
        }
    }
}
