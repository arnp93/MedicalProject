using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class NewLangsToSocialNetworks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WhatsApp",
                table: "socialNetworks",
                newName: "WhatsAppFa");

            migrationBuilder.RenameColumn(
                name: "Twitter",
                table: "socialNetworks",
                newName: "WhatsAppEs");

            migrationBuilder.RenameColumn(
                name: "Telegram",
                table: "socialNetworks",
                newName: "WhatsAppEng");

            migrationBuilder.RenameColumn(
                name: "Instagram",
                table: "socialNetworks",
                newName: "TwitterFa");

            migrationBuilder.RenameColumn(
                name: "Facebook",
                table: "socialNetworks",
                newName: "TwitterEs");

            migrationBuilder.AddColumn<string>(
                name: "FacebookEng",
                table: "socialNetworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookEs",
                table: "socialNetworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookFa",
                table: "socialNetworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramEng",
                table: "socialNetworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramEs",
                table: "socialNetworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramFa",
                table: "socialNetworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelegramEng",
                table: "socialNetworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelegramEs",
                table: "socialNetworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelegramFa",
                table: "socialNetworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterEng",
                table: "socialNetworks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacebookEng",
                table: "socialNetworks");

            migrationBuilder.DropColumn(
                name: "FacebookEs",
                table: "socialNetworks");

            migrationBuilder.DropColumn(
                name: "FacebookFa",
                table: "socialNetworks");

            migrationBuilder.DropColumn(
                name: "InstagramEng",
                table: "socialNetworks");

            migrationBuilder.DropColumn(
                name: "InstagramEs",
                table: "socialNetworks");

            migrationBuilder.DropColumn(
                name: "InstagramFa",
                table: "socialNetworks");

            migrationBuilder.DropColumn(
                name: "TelegramEng",
                table: "socialNetworks");

            migrationBuilder.DropColumn(
                name: "TelegramEs",
                table: "socialNetworks");

            migrationBuilder.DropColumn(
                name: "TelegramFa",
                table: "socialNetworks");

            migrationBuilder.DropColumn(
                name: "TwitterEng",
                table: "socialNetworks");

            migrationBuilder.RenameColumn(
                name: "WhatsAppFa",
                table: "socialNetworks",
                newName: "WhatsApp");

            migrationBuilder.RenameColumn(
                name: "WhatsAppEs",
                table: "socialNetworks",
                newName: "Twitter");

            migrationBuilder.RenameColumn(
                name: "WhatsAppEng",
                table: "socialNetworks",
                newName: "Telegram");

            migrationBuilder.RenameColumn(
                name: "TwitterFa",
                table: "socialNetworks",
                newName: "Instagram");

            migrationBuilder.RenameColumn(
                name: "TwitterEs",
                table: "socialNetworks",
                newName: "Facebook");
        }
    }
}
