using Microsoft.EntityFrameworkCore.Migrations;

namespace Holtz_Academy.API.Migrations
{
    public partial class _003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchCode",
                table: "Equipament",
                type: "INT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipament_BranchCode",
                table: "Equipament",
                column: "BranchCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipament_Branch_BranchCode",
                table: "Equipament",
                column: "BranchCode",
                principalTable: "Branch",
                principalColumn: "BranchCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipament_Branch_BranchCode",
                table: "Equipament");

            migrationBuilder.DropIndex(
                name: "IX_Equipament_BranchCode",
                table: "Equipament");

            migrationBuilder.DropColumn(
                name: "BranchCode",
                table: "Equipament");
        }
    }
}
