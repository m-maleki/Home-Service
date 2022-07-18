using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HS.Infrastructures.Database.SqlServer.Migrations
{
    public partial class ini5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "Customers",
                newName: "ShebaNumber");

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 27,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 31,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 32,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 35,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 36,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 37,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 40,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 41,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 45,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 46,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 49,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 50,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 51,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 52,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 53,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 54,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 55,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 56,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 57,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 58,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 59,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 60,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 61,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 62,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 63,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 64,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 65,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 66,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 67,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 68,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 69,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 70,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 71,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 72,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 73,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 74,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 75,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 76,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 77,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 78,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 79,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 80,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 81,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 82,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 83,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 84,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 85,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 86,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 87,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 88,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 89,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 90,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 91,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 92,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 93,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 94,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 95,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 96,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 97,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 98,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 99,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 100,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 101,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 102,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 103,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 104,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 105,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 106,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 107,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 108,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 51, 55, 37, DateTimeKind.Local).AddTicks(6780));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ShebaNumber",
                table: "Customers",
                newName: "MobileNumber");

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 27,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 31,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 32,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 35,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 36,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 37,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 40,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 41,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 45,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 46,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 49,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 50,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 51,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 52,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 53,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 54,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 55,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 56,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 57,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 58,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 59,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 60,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 61,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 62,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 63,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 64,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 65,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 66,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 67,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 68,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 69,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 70,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 71,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 72,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 73,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 74,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 75,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 76,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 77,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 78,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 79,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 80,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 81,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 82,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 83,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 84,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 85,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 86,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 87,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 88,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 89,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 90,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 91,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 92,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 93,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 94,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 95,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 96,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 97,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 98,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 99,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 100,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 101,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 102,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 103,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 104,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 105,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 106,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 107,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 108,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 11, 2, 33, 903, DateTimeKind.Local).AddTicks(3458));
        }
    }
}
