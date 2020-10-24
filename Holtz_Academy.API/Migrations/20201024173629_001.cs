using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Holtz_Academy.API.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipaments",
                columns: table => new
                {
                    EquipamentCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipamentName = table.Column<string>(nullable: true),
                    EquipamentStatus = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipaments", x => x.EquipamentCode);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentCode = table.Column<int>(nullable: false),
                    StudentaReason = table.Column<string>(nullable: true),
                    StudentStatus = table.Column<byte>(nullable: false),
                    StudentBirthDate = table.Column<DateTime>(nullable: false),
                    StudentStreet = table.Column<string>(nullable: true),
                    StudentNeighborhood = table.Column<string>(nullable: true),
                    StudentNumber = table.Column<int>(nullable: false),
                    StudentCityName = table.Column<string>(nullable: true),
                    TeatcherCode = table.Column<int>(nullable: false),
                    BranchCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentCode);
                });

            migrationBuilder.CreateTable(
                name: "Teatchers",
                columns: table => new
                {
                    TeatcherCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeatcherReason = table.Column<string>(nullable: true),
                    TeatcherStatus = table.Column<byte>(nullable: false),
                    TeatcherBirthDate = table.Column<DateTime>(nullable: false),
                    TeatcherStreet = table.Column<string>(nullable: true),
                    TeatcherNeighborhood = table.Column<string>(nullable: true),
                    TeatcherNumber = table.Column<int>(nullable: false),
                    TeatcherCityName = table.Column<string>(nullable: true),
                    BranchCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teatchers", x => x.TeatcherCode);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchReason = table.Column<string>(nullable: true),
                    BranchStatus = table.Column<byte>(nullable: false),
                    BranchStreet = table.Column<string>(nullable: true),
                    BranchNeighborhood = table.Column<string>(nullable: true),
                    BranchNumber = table.Column<int>(nullable: false),
                    BranchCityName = table.Column<string>(nullable: true),
                    StudentCode = table.Column<int>(nullable: false),
                    StudentCode1 = table.Column<int>(nullable: true),
                    TeatcherCode = table.Column<int>(nullable: false),
                    TeatcherCode1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchCode);
                    table.ForeignKey(
                        name: "FK_Branches_Students_StudentCode1",
                        column: x => x.StudentCode1,
                        principalTable: "Students",
                        principalColumn: "StudentCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branches_Teatchers_TeatcherCode1",
                        column: x => x.TeatcherCode1,
                        principalTable: "Teatchers",
                        principalColumn: "TeatcherCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_StudentCode1",
                table: "Branches",
                column: "StudentCode1");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_TeatcherCode1",
                table: "Branches",
                column: "TeatcherCode1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeatcherCode",
                table: "Students",
                column: "TeatcherCode");

            migrationBuilder.CreateIndex(
                name: "IX_Teatchers_BranchCode",
                table: "Teatchers",
                column: "BranchCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teatchers_TeatcherCode",
                table: "Students",
                column: "TeatcherCode",
                principalTable: "Teatchers",
                principalColumn: "TeatcherCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Branches_StudentCode",
                table: "Students",
                column: "StudentCode",
                principalTable: "Branches",
                principalColumn: "BranchCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teatchers_Branches_BranchCode",
                table: "Teatchers",
                column: "BranchCode",
                principalTable: "Branches",
                principalColumn: "BranchCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Students_StudentCode1",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Teatchers_TeatcherCode1",
                table: "Branches");

            migrationBuilder.DropTable(
                name: "Equipaments");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teatchers");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
