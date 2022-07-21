using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HS.Infrastructures.Database.SqlServer.Migrations
{
    public partial class init444 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisterDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 27,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 31,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 32,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 35,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 36,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 37,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 40,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 41,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 45,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 46,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 49,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 50,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 51,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 52,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 53,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 54,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 55,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 56,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 57,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 58,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 59,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 60,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 61,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 62,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 63,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 64,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 65,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 66,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 67,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 68,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 69,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 70,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 71,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 72,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 73,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 74,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 75,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 76,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 77,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 78,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 79,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 80,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 81,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 82,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 83,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 84,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 85,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 86,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 87,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 88,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 89,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 90,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 91,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 92,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 93,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 94,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 95,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 96,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 97,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 98,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 99,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 100,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 101,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 102,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 103,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 104,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 105,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 106,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 107,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 108,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 21, 11, 11, 28, 12, DateTimeKind.Local).AddTicks(4556));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegisterDate",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 27,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 31,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 32,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 35,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 36,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 37,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 40,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 41,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 45,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 46,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 49,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 50,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 51,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 52,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 53,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 54,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 55,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 56,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 57,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 58,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 59,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 60,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 61,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 62,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 63,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 64,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 65,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 66,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 67,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 68,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 69,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 70,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 71,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 72,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 73,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 74,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 75,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 76,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 77,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 78,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 79,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 80,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 81,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 82,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 83,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 84,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 85,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 86,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 87,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 88,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 89,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 90,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 91,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 92,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 93,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 94,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 95,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 96,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 97,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 98,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 99,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 100,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 101,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 102,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 103,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 104,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 105,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 106,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 107,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 108,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6218));
        }
    }
}
