using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class newTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "siteStatics",
                columns: table => new
                {
                    SiteStaticId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FooterImageName = table.Column<string>(nullable: true),
                    MiniTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    CoverImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteStatics", x => x.SiteStaticId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "siteStatics");
        }
    }
}
