using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class deleteAlgo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "subPostDescriptionId",
                table: "subPosts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "subPostDescriptionId",
                table: "subPosts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
