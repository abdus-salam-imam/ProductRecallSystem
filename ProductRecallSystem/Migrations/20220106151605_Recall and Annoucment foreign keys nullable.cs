using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductRecallSystem.Migrations
{
    public partial class RecallandAnnoucmentforeignkeysnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Announcements_AnnouncementId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Recalls_RecallId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "RecallId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AnnouncementId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Announcements_AnnouncementId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Recalls_RecallId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "RecallId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnnouncementId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Announcements_AnnouncementId",
                table: "Products",
                column: "AnnouncementId",
                principalTable: "Announcements",
                principalColumn: "AnnouncementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Recalls_RecallId",
                table: "Products",
                column: "RecallId",
                principalTable: "Recalls",
                principalColumn: "RecallId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
