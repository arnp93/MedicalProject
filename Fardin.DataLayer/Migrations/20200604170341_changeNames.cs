using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class changeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubPosts_posts_PostId",
                table: "SubPosts");

            migrationBuilder.DropTable(
                name: "subPostDescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubPosts",
                table: "SubPosts");

            migrationBuilder.RenameTable(
                name: "SubPosts",
                newName: "subPosts");

            migrationBuilder.RenameIndex(
                name: "IX_SubPosts_PostId",
                table: "subPosts",
                newName: "IX_subPosts_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subPosts",
                table: "subPosts",
                column: "SubPostId");

            migrationBuilder.CreateTable(
                name: "subPostDescriptions",
                columns: table => new
                {
                    SubPostDescriptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    imageName = table.Column<string>(nullable: true),
                    SubPostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subPostDescriptions", x => x.SubPostDescriptionId);
                    table.ForeignKey(
                        name: "FK_subPostDescriptions_subPosts_SubPostId",
                        column: x => x.SubPostId,
                        principalTable: "subPosts",
                        principalColumn: "SubPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_subPostDescriptions_SubPostId",
                table: "subPostDescriptions",
                column: "SubPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_subPosts_posts_PostId",
                table: "subPosts",
                column: "PostId",
                principalTable: "posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subPosts_posts_PostId",
                table: "subPosts");

            migrationBuilder.DropTable(
                name: "subPostDescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subPosts",
                table: "subPosts");

            migrationBuilder.RenameTable(
                name: "subPosts",
                newName: "SubPosts");

            migrationBuilder.RenameIndex(
                name: "IX_subPosts_PostId",
                table: "SubPosts",
                newName: "IX_SubPosts_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubPosts",
                table: "SubPosts",
                column: "SubPostId");

            migrationBuilder.CreateTable(
                name: "subPostDescription",
                columns: table => new
                {
                    DetailsDescriptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubPostId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    imageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subPostDescription", x => x.DetailsDescriptionId);
                    table.ForeignKey(
                        name: "FK_subPostDescription_SubPosts_SubPostId",
                        column: x => x.SubPostId,
                        principalTable: "SubPosts",
                        principalColumn: "SubPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_subPostDescription_SubPostId",
                table: "subPostDescription",
                column: "SubPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubPosts_posts_PostId",
                table: "SubPosts",
                column: "PostId",
                principalTable: "posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
