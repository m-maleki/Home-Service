using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HS.Infrastructures.Database.SqlServer.Migrations
{
    public partial class _56465 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "ExpertHomeService",
                columns: table => new
                {
                    ExpertsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HomeServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertHomeService", x => new { x.ExpertsId, x.HomeServicesId });
                    table.ForeignKey(
                        name: "FK_ExpertHomeService_Experts_ExpertsId",
                        column: x => x.ExpertsId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertHomeService_HomeServices_HomeServicesId",
                        column: x => x.HomeServicesId,
                        principalTable: "HomeServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpertHomeService_HomeServicesId",
                table: "ExpertHomeService",
                column: "HomeServicesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpertHomeService");

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
    }
}
