using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class addImageGallery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "contacts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contacts",
                table: "contacts",
                column: "ContactUsId");

            migrationBuilder.CreateTable(
                name: "imageGalleries",
                columns: table => new
                {
                    ImageGalleryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    postId = table.Column<int>(nullable: false),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imageGalleries", x => x.ImageGalleryId);
                    table.ForeignKey(
                        name: "FK_imageGalleries_posts_postId",
                        column: x => x.postId,
                        principalTable: "posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_imageGalleries_postId",
                table: "imageGalleries",
                column: "postId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "imageGalleries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contacts",
                table: "contacts");

            migrationBuilder.RenameTable(
                name: "contacts",
                newName: "Contacts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "ContactUsId");
        }
    }
}
