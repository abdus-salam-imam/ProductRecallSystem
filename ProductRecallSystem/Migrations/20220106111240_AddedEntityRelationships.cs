using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductRecallSystem.Migrations
{
    public partial class AddedEntityRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnnouncementId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecallId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_AnnouncementId",
                table: "Products",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturerId",
                table: "Products",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RecallId",
                table: "Products",
                column: "RecallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Announcements_AnnouncementId",
                table: "Products",
                column: "AnnouncementId",
                principalTable: "Announcements",
                principalColumn: "AnnouncementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                table: "Products",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "ManufacturerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Recalls_RecallId",
                table: "Products",
                column: "RecallId",
                principalTable: "Recalls",
                principalColumn: "RecallId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Announcements_AnnouncementId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Recalls_RecallId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AnnouncementId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ManufacturerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_RecallId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AnnouncementId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RecallId",
                table: "Products");
        }
    }
}
