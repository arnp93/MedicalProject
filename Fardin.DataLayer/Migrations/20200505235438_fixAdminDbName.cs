using Microsoft.EntityFrameworkCore.Migrations;

namespace Fardin.DataLayer.Migrations
{
    public partial class fixAdminDbName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_admin_AdminPanelId",
                table: "posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admin",
                table: "admin");

            migrationBuilder.RenameTable(
                name: "admin",
                newName: "admins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admins",
                table: "admins",
                column: "AdminPanelId");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_admins_AdminPanelId",
                table: "posts",
                column: "AdminPanelId",
                principalTable: "admins",
                principalColumn: "AdminPanelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_admins_AdminPanelId",
                table: "posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admins",
                table: "admins");

            migrationBuilder.RenameTable(
                name: "admins",
                newName: "admin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admin",
                table: "admin",
                column: "AdminPanelId");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_admin_AdminPanelId",
                table: "posts",
                column: "AdminPanelId",
                principalTable: "admin",
                principalColumn: "AdminPanelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
