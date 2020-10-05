using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class _deleteLang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_languages_Language_Id",
                table: "posts");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropIndex(
                name: "IX_posts_Language_Id",
                table: "posts");

            migrationBuilder.AddColumn<string>(
                name: "languageName",
                table: "posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "languageName",
                table: "posts");

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    Language_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Language_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_posts_Language_Id",
                table: "posts",
                column: "Language_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_languages_Language_Id",
                table: "posts",
                column: "Language_Id",
                principalTable: "languages",
                principalColumn: "Language_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
