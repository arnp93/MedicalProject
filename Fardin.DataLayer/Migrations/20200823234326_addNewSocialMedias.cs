using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class addNewSocialMedias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telegram",
                table: "socialNetworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhatsApp",
                table: "socialNetworks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telegram",
                table: "socialNetworks");

            migrationBuilder.DropColumn(
                name: "WhatsApp",
                table: "socialNetworks");
        }
    }
}
