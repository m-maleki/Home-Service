using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HS.Infrastructures.Database.SqlServer.Migrations
{
    public partial class ininin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cities",
                newName: "CityId");

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 27,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 31,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 32,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 35,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 36,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 37,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 40,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 41,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 45,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 46,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 49,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 50,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 51,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 52,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 53,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 54,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 55,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 56,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 57,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 58,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 59,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 60,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 61,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 62,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 63,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 64,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 65,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 66,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 67,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 68,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 69,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 70,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 71,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 72,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 73,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 74,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 75,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 76,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 77,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 78,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 79,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 80,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 81,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 82,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 83,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 84,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 85,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 86,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 87,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 88,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 89,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 90,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 91,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 92,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 93,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 94,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 95,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 96,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 97,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 98,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 99,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 100,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 101,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 102,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 103,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 104,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 105,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 106,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 107,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 108,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 23, 3, 1, 903, DateTimeKind.Local).AddTicks(4533));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Cities",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 27,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 31,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 32,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 35,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 36,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 37,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 40,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 41,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 45,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 46,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 49,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 50,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 51,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 52,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 53,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 54,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 55,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 56,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 57,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 58,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 59,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 60,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 61,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 62,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 63,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 64,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 65,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 66,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 67,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 68,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 69,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 70,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 71,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 72,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 73,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 74,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 75,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 76,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 77,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 78,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 79,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 80,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 81,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 82,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 83,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 84,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 85,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 86,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 87,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 88,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 89,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 90,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 91,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 92,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 93,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 94,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 95,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 96,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 97,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 98,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 99,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 100,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 101,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 102,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 103,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 104,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 105,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 106,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 107,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 108,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 16, 22, 34, 46, 167, DateTimeKind.Local).AddTicks(7836));
        }
    }
}
