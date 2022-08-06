using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HS.Infrastructures.Database.SqlServer.Migrations
{
    public partial class addConfirmKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Experts_ExpertId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Cities_CityId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeServices_HomeServiceSubCategories_HomeServiceSubCategoryId",
                table: "HomeServices");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeServiceSubCategories_HomeServiceCategories_HomeServiceCategoryId",
                table: "HomeServiceSubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_HomeServices_HomeServiceId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Suggestions_Experts_ExpertId",
                table: "Suggestions");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmationToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 27,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 31,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 32,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 35,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 416, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 36,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 37,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 40,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 41,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 45,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 46,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 49,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 50,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 51,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 52,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 53,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 54,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 55,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 56,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 57,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 58,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 59,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 60,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 61,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 62,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 63,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 64,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 65,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 66,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 67,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 68,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 69,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 70,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 71,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 72,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 73,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 74,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 75,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 76,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 77,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 78,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 79,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 80,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 81,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 82,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 83,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 84,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 85,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 86,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 87,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 88,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 89,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 90,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 91,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 92,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 93,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 94,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 95,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 96,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 97,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 98,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 99,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 100,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 101,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 102,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 103,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 104,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 105,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 106,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 107,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 108,
                column: "RegisterDate",
                value: new DateTime(2022, 8, 6, 19, 23, 23, 417, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Experts_ExpertId",
                table: "Comments",
                column: "ExpertId",
                principalTable: "Experts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Cities_CityId",
                table: "Customers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeServices_HomeServiceSubCategories_HomeServiceSubCategoryId",
                table: "HomeServices",
                column: "HomeServiceSubCategoryId",
                principalTable: "HomeServiceSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeServiceSubCategories_HomeServiceCategories_HomeServiceCategoryId",
                table: "HomeServiceSubCategories",
                column: "HomeServiceCategoryId",
                principalTable: "HomeServiceCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_HomeServices_HomeServiceId",
                table: "Orders",
                column: "HomeServiceId",
                principalTable: "HomeServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suggestions_Experts_ExpertId",
                table: "Suggestions",
                column: "ExpertId",
                principalTable: "Experts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Experts_ExpertId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Cities_CityId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeServices_HomeServiceSubCategories_HomeServiceSubCategoryId",
                table: "HomeServices");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeServiceSubCategories_HomeServiceCategories_HomeServiceCategoryId",
                table: "HomeServiceSubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_HomeServices_HomeServiceId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Suggestions_Experts_ExpertId",
                table: "Suggestions");

            migrationBuilder.DropColumn(
                name: "ConfirmationToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "HomeServiceCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "HomeServiceSubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 24,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 25,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 26,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 27,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 28,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 29,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 30,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 31,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 32,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 33,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 34,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 35,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 36,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 37,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 38,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 39,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 40,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 41,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 42,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 43,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 44,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 45,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 46,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 47,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 48,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 49,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 50,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 51,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 52,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 53,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 54,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 55,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 56,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 57,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 58,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 59,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 60,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 61,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 62,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 63,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 64,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 65,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 66,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 67,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 68,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 69,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 70,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 71,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 72,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 73,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 74,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 75,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 76,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 77,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 78,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 79,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 80,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 81,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 82,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 83,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 84,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 85,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 86,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 87,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 88,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 89,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 90,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 91,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 92,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 93,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 94,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 95,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 96,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 97,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 98,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 99,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 100,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 101,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 102,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 103,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 104,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 105,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 106,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 107,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "HomeServices",
                keyColumn: "Id",
                keyValue: 108,
                column: "RegisterDate",
                value: new DateTime(2022, 7, 24, 11, 33, 50, 476, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Experts_ExpertId",
                table: "Comments",
                column: "ExpertId",
                principalTable: "Experts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Cities_CityId",
                table: "Customers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeServices_HomeServiceSubCategories_HomeServiceSubCategoryId",
                table: "HomeServices",
                column: "HomeServiceSubCategoryId",
                principalTable: "HomeServiceSubCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeServiceSubCategories_HomeServiceCategories_HomeServiceCategoryId",
                table: "HomeServiceSubCategories",
                column: "HomeServiceCategoryId",
                principalTable: "HomeServiceCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_HomeServices_HomeServiceId",
                table: "Orders",
                column: "HomeServiceId",
                principalTable: "HomeServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suggestions_Experts_ExpertId",
                table: "Suggestions",
                column: "ExpertId",
                principalTable: "Experts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
