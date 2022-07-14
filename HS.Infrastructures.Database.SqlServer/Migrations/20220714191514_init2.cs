using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HS.Infrastructures.Database.SqlServer.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpertSpecialty");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "SpecialtyCategories");

            migrationBuilder.AddColumn<Guid>(
                name: "ExpertId",
                table: "HomeServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HomeServices_ExpertId",
                table: "HomeServices",
                column: "ExpertId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeServices_Experts_ExpertId",
                table: "HomeServices",
                column: "ExpertId",
                principalTable: "Experts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeServices_Experts_ExpertId",
                table: "HomeServices");

            migrationBuilder.DropIndex(
                name: "IX_HomeServices_ExpertId",
                table: "HomeServices");

            migrationBuilder.DropColumn(
                name: "ExpertId",
                table: "HomeServices");

            migrationBuilder.CreateTable(
                name: "SpecialtyCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialtyCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialtyCategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialties_SpecialtyCategories_SpecialtyCategoryId",
                        column: x => x.SpecialtyCategoryId,
                        principalTable: "SpecialtyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpertSpecialty",
                columns: table => new
                {
                    ExpertsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialtiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertSpecialty", x => new { x.ExpertsId, x.SpecialtiesId });
                    table.ForeignKey(
                        name: "FK_ExpertSpecialty_Experts_ExpertsId",
                        column: x => x.ExpertsId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertSpecialty_Specialties_SpecialtiesId",
                        column: x => x.SpecialtiesId,
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpertSpecialty_SpecialtiesId",
                table: "ExpertSpecialty",
                column: "SpecialtiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_SpecialtyCategoryId",
                table: "Specialties",
                column: "SpecialtyCategoryId");
        }
    }
}
