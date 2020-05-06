using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    AdminPanelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    imgName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.AdminPanelId);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PostText = table.Column<string>(nullable: true),
                    PostImg = table.Column<string>(nullable: true),
                    AdminPanelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_posts_admin_AdminPanelId",
                        column: x => x.AdminPanelId,
                        principalTable: "admin",
                        principalColumn: "AdminPanelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "postDetails",
                columns: table => new
                {
                    PostDetailId = table.Column<string>(nullable: false),
                    PostTitle = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    TextResumen = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postDetails", x => x.PostDetailId);
                    table.ForeignKey(
                        name: "FK_postDetails_posts_PostId",
                        column: x => x.PostId,
                        principalTable: "posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detailsDescriptions",
                columns: table => new
                {
                    DetailsDescriptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    imageName = table.Column<string>(nullable: true),
                    videoName = table.Column<string>(nullable: true),
                    PostDetailsId = table.Column<int>(nullable: false),
                    PostDetailId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detailsDescriptions", x => x.DetailsDescriptionId);
                    table.ForeignKey(
                        name: "FK_detailsDescriptions_postDetails_PostDetailId",
                        column: x => x.PostDetailId,
                        principalTable: "postDetails",
                        principalColumn: "PostDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detailsDescriptions_PostDetailId",
                table: "detailsDescriptions",
                column: "PostDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_postDetails_PostId",
                table: "postDetails",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_posts_AdminPanelId",
                table: "posts",
                column: "AdminPanelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detailsDescriptions");

            migrationBuilder.DropTable(
                name: "postDetails");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "admin");
        }
    }
}
