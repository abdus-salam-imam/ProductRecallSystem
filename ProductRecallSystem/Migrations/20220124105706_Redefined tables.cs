using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductRecallSystem.Migrations
{
    public partial class Redefinedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recalls_Announcements_AnnouncementId",
                table: "Recalls");

            migrationBuilder.DropIndex(
                name: "IX_Recalls_AnnouncementId",
                table: "Recalls");

            migrationBuilder.DropColumn(
                name: "AnnouncementId",
                table: "Recalls");

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecallId",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId1",
                table: "Products",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_RecallId",
                table: "Announcements",
                column: "RecallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_Recalls_RecallId",
                table: "Announcements",
                column: "RecallId",
                principalTable: "Recalls",
                principalColumn: "RecallId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ProductId1",
                table: "Products",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_Recalls_RecallId",
                table: "Announcements");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ProductId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_RecallId",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RecallId",
                table: "Announcements");

            migrationBuilder.AddColumn<int>(
                name: "AnnouncementId",
                table: "Recalls",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recalls_AnnouncementId",
                table: "Recalls",
                column: "AnnouncementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recalls_Announcements_AnnouncementId",
                table: "Recalls",
                column: "AnnouncementId",
                principalTable: "Announcements",
                principalColumn: "AnnouncementId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
