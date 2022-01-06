using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductRecallSystem.Migrations
{
    public partial class addedmanufacturernaviationpropertyinRecall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "Recalls",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recalls_ManufacturerId",
                table: "Recalls",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recalls_Manufacturers_ManufacturerId",
                table: "Recalls",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "ManufacturerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recalls_Manufacturers_ManufacturerId",
                table: "Recalls");

            migrationBuilder.DropIndex(
                name: "IX_Recalls_ManufacturerId",
                table: "Recalls");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Recalls");
        }
    }
}
