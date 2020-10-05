using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class fixDescriptiom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_subPostDescriptions_SubPostId",
                table: "subPostDescriptions");

            migrationBuilder.AddColumn<int>(
                name: "subPostDescriptionId",
                table: "subPosts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_subPostDescriptions_SubPostId",
                table: "subPostDescriptions",
                column: "SubPostId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_subPostDescriptions_SubPostId",
                table: "subPostDescriptions");

            migrationBuilder.DropColumn(
                name: "subPostDescriptionId",
                table: "subPosts");

            migrationBuilder.CreateIndex(
                name: "IX_subPostDescriptions_SubPostId",
                table: "subPostDescriptions",
                column: "SubPostId");
        }
    }
}
