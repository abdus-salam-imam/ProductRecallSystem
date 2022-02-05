using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductRecallSystem.Migrations
{
    public partial class RestructureDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Announcements_AnnouncementId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Recalls_RecallId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AnnouncementId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_RecallId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AnnouncementId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RecallId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "AnnouncementId",
                table: "Recalls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Recalls",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recalls_AnnouncementId",
                table: "Recalls",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_Recalls_ProductId",
                table: "Recalls",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recalls_Announcements_AnnouncementId",
                table: "Recalls",
                column: "AnnouncementId",
                principalTable: "Announcements",
                principalColumn: "AnnouncementId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recalls_Products_ProductId",
                table: "Recalls",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recalls_Announcements_AnnouncementId",
                table: "Recalls");

            migrationBuilder.DropForeignKey(
                name: "FK_Recalls_Products_ProductId",
                table: "Recalls");

            migrationBuilder.DropIndex(
                name: "IX_Recalls_AnnouncementId",
                table: "Recalls");

            migrationBuilder.DropIndex(
                name: "IX_Recalls_ProductId",
                table: "Recalls");

            migrationBuilder.DropColumn(
                name: "AnnouncementId",
                table: "Recalls");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Recalls");

            migrationBuilder.AddColumn<int>(
                name: "AnnouncementId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecallId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_AnnouncementId",
                table: "Products",
                column: "AnnouncementId");

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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Recalls_RecallId",
                table: "Products",
                column: "RecallId",
                principalTable: "Recalls",
                principalColumn: "RecallId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
