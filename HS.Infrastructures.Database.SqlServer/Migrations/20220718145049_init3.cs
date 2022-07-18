using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HS.Infrastructures.Database.SqlServer.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfExecution",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 959, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 959, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 959, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 959, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 959, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 959, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 959, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 959, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 959, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 27,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 31,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 32,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 35,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 36,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 37,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 40,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 41,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 45,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 46,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 49,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 50,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 51,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 52,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 53,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 54,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 55,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 56,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 57,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 58,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 59,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 60,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 61,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 62,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 63,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 64,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 65,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 66,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 67,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 68,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 69,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 70,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 71,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 72,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 73,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 74,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 75,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 76,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 77,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 78,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 79,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 80,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 81,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 82,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 83,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 84,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 85,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 86,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 87,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 88,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 89,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 90,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 91,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 92,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 93,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 94,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 95,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 96,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 97,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 98,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 99,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 100,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 101,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 102,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 103,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 104,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 105,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 106,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 107,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 108,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 20, 48, 960, DateTimeKind.Local).AddTicks(1494));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfExecution",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 27,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 31,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 32,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 35,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 36,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 37,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 40,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 41,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 45,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 46,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 49,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 50,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 51,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 52,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 53,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 54,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 55,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 56,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 57,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 58,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 59,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 60,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 61,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 62,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 63,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 64,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 65,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 66,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 67,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 68,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 69,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 70,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 71,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 72,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 73,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 74,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 75,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 76,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 77,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 78,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 79,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 80,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 81,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 82,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 83,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 84,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 85,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 86,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 87,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 88,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 89,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 90,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 91,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 92,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 93,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 94,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 95,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 96,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 97,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 98,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 99,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 100,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 101,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 102,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 103,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 104,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 105,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 106,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 107,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 108,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 18, 19, 0, 35, 856, DateTimeKind.Local).AddTicks(3622));
        }
    }
}
