using Microsoft.EntityFrameworkCore.Migrations;

namespace Holtz_Academy.API.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipamentReason",
                table: "Equipaments");

            migrationBuilder.AddColumn<string>(
                name: "EquipamentName",
                table: "Equipaments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipamentName",
                table: "Equipaments");

            migrationBuilder.AddColumn<string>(
                name: "EquipamentReason",
                table: "Equipaments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
