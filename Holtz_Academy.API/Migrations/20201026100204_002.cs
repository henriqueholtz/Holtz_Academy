using Microsoft.EntityFrameworkCore.Migrations;

namespace Holtz_Academy.API.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teatcher_Branch_BranchCode1",
                table: "Teatcher");

            migrationBuilder.DropIndex(
                name: "IX_Teatcher_BranchCode1",
                table: "Teatcher");

            migrationBuilder.DropColumn(
                name: "BranchCode1",
                table: "Teatcher");

            migrationBuilder.AlterColumn<int>(
                name: "BranchCode",
                table: "Teatcher",
                type: "INT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teatcher_BranchCode",
                table: "Teatcher",
                column: "BranchCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Teatcher_Branch_BranchCode",
                table: "Teatcher",
                column: "BranchCode",
                principalTable: "Branch",
                principalColumn: "BranchCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teatcher_Branch_BranchCode",
                table: "Teatcher");

            migrationBuilder.DropIndex(
                name: "IX_Teatcher_BranchCode",
                table: "Teatcher");

            migrationBuilder.AlterColumn<int>(
                name: "BranchCode",
                table: "Teatcher",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchCode1",
                table: "Teatcher",
                type: "INT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teatcher_BranchCode1",
                table: "Teatcher",
                column: "BranchCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_Teatcher_Branch_BranchCode1",
                table: "Teatcher",
                column: "BranchCode1",
                principalTable: "Branch",
                principalColumn: "BranchCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
