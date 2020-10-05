using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class fixDescriptionBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subPostDescription_SubPosts_SubPostId",
                table: "subPostDescription");

            migrationBuilder.DropColumn(
                name: "SubPostsId",
                table: "subPostDescription");

            migrationBuilder.AlterColumn<int>(
                name: "SubPostId",
                table: "subPostDescription",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_subPostDescription_SubPosts_SubPostId",
                table: "subPostDescription",
                column: "SubPostId",
                principalTable: "SubPosts",
                principalColumn: "SubPostId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subPostDescription_SubPosts_SubPostId",
                table: "subPostDescription");

            migrationBuilder.AlterColumn<int>(
                name: "SubPostId",
                table: "subPostDescription",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SubPostsId",
                table: "subPostDescription",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_subPostDescription_SubPosts_SubPostId",
                table: "subPostDescription",
                column: "SubPostId",
                principalTable: "SubPosts",
                principalColumn: "SubPostId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
