using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Holtz_Academy.API.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    BranchCode = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchReason = table.Column<string>(type: "VARCHAR(75)", nullable: true),
                    BranchStatus = table.Column<byte>(type: "TINYINT", nullable: true),
                    BranchStreet = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    BranchNeighborhood = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    BranchNumber = table.Column<int>(nullable: true),
                    BranchCityName = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.BranchCode);
                });

            migrationBuilder.CreateTable(
                name: "Equipament",
                columns: table => new
                {
                    EquipamentCode = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipamentName = table.Column<string>(type: "VARCHAR(75)", nullable: true),
                    EquipamentStatus = table.Column<byte>(type: "TINYINT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipament", x => x.EquipamentCode);
                });

            migrationBuilder.CreateTable(
                name: "Teatcher",
                columns: table => new
                {
                    TeatcherCode = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeatcherReason = table.Column<string>(type: "VARCHAR(75)", nullable: true),
                    TeatcherStatus = table.Column<byte>(type: "TINYINT", nullable: true),
                    TeatcherBirthDate = table.Column<DateTime>(nullable: true),
                    TeatcherStreet = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    TeatcherNeighborhood = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    TeatcherNumber = table.Column<int>(nullable: true),
                    TeatcherCityName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    BranchCode = table.Column<int>(nullable: true),
                    BranchCode1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teatcher", x => x.TeatcherCode);
                    table.ForeignKey(
                        name: "FK_Teatcher_Branch_BranchCode1",
                        column: x => x.BranchCode1,
                        principalTable: "Branch",
                        principalColumn: "BranchCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentCode = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentaReason = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    StudentStatus = table.Column<byte>(type: "TINYINT", nullable: true),
                    StudentBirthDate = table.Column<DateTime>(nullable: true),
                    StudentStreet = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    StudentNeighborhood = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    StudentNumber = table.Column<int>(nullable: true),
                    StudentCityName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    TeatcherCode = table.Column<int>(type: "INT", nullable: true),
                    BranchCode = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentCode);
                    table.ForeignKey(
                        name: "FK_Student_Branch_BranchCode",
                        column: x => x.BranchCode,
                        principalTable: "Branch",
                        principalColumn: "BranchCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Teatcher_TeatcherCode",
                        column: x => x.TeatcherCode,
                        principalTable: "Teatcher",
                        principalColumn: "TeatcherCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_BranchCode",
                table: "Student",
                column: "BranchCode");

            migrationBuilder.CreateIndex(
                name: "IX_Student_TeatcherCode",
                table: "Student",
                column: "TeatcherCode");

            migrationBuilder.CreateIndex(
                name: "IX_Teatcher_BranchCode1",
                table: "Teatcher",
                column: "BranchCode1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipament");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teatcher");

            migrationBuilder.DropTable(
                name: "Branch");
        }
    }
}
