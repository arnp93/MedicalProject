using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
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
                    table.PrimaryKey("PK_admins", x => x.AdminPanelId);
                });

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

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SectionId = table.Column<int>(nullable: false),
                    PostText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    PostImg = table.Column<string>(nullable: true),
                    AdminPanelId = table.Column<int>(nullable: false),
                    Language_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_posts_admins_AdminPanelId",
                        column: x => x.AdminPanelId,
                        principalTable: "admins",
                        principalColumn: "AdminPanelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_posts_languages_Language_Id",
                        column: x => x.Language_Id,
                        principalTable: "languages",
                        principalColumn: "Language_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubPosts",
                columns: table => new
                {
                    SubPostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    TextResumen = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPosts", x => x.SubPostId);
                    table.ForeignKey(
                        name: "FK_SubPosts_posts_PostId",
                        column: x => x.PostId,
                        principalTable: "posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subPostDescription",
                columns: table => new
                {
                    DetailsDescriptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    imageName = table.Column<string>(nullable: true),
                    videoName = table.Column<string>(nullable: true),
                    SubPostsId = table.Column<int>(nullable: false),
                    SubPostId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subPostDescription", x => x.DetailsDescriptionId);
                    table.ForeignKey(
                        name: "FK_subPostDescription_SubPosts_SubPostId",
                        column: x => x.SubPostId,
                        principalTable: "SubPosts",
                        principalColumn: "SubPostId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_subPostDescription_SubPostId",
                table: "subPostDescription",
                column: "SubPostId");

            migrationBuilder.CreateIndex(
                name: "IX_SubPosts_PostId",
                table: "SubPosts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_posts_AdminPanelId",
                table: "posts",
                column: "AdminPanelId");

            migrationBuilder.CreateIndex(
                name: "IX_posts_Language_Id",
                table: "posts",
                column: "Language_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subPostDescription");

            migrationBuilder.DropTable(
                name: "SubPosts");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "languages");
        }
    }
}
