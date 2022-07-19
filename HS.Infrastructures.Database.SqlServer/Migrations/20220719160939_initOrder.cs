using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HS.Infrastructures.Database.SqlServer.Migrations
{
    public partial class initOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeServiceCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeServiceCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShebaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShebaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HomeServiceSubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeServiceCategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeServiceSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeServiceSubCategories_HomeServiceCategories_HomeServiceCategoryId",
                        column: x => x.HomeServiceCategoryId,
                        principalTable: "HomeServiceCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HomeServiceSubCategoryId = table.Column<int>(type: "int", nullable: true),
                    ImgSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasePrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeServices_HomeServiceSubCategories_HomeServiceSubCategoryId",
                        column: x => x.HomeServiceSubCategoryId,
                        principalTable: "HomeServiceSubCategories",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HomeServiceId = table.Column<int>(type: "int", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfExecution = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_HomeServices_HomeServiceId",
                        column: x => x.HomeServiceId,
                        principalTable: "HomeServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderFiles_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suggestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuggestedPrice = table.Column<double>(type: "float", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationOfWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAccept = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suggestions_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suggestions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "آذربایجان شرقی" },
                    { 2, "آذربایجان غربی" },
                    { 3, "اردبیل" },
                    { 4, "اصفهان" },
                    { 5, "البرز" },
                    { 6, "ایلام" },
                    { 7, "بوشهر" },
                    { 8, "تهران" },
                    { 9, "چهارمحال و بختیاری" },
                    { 10, "خراسان جنوبی" },
                    { 11, "خراسان رضوی" },
                    { 12, "خراسان شمالی" },
                    { 13, "خوزستان" },
                    { 14, "زنجان" },
                    { 15, "سمنان" },
                    { 16, "سیستان و بلوچستان" },
                    { 17, "فارس" },
                    { 18, "قزوین" },
                    { 19, "قم" },
                    { 20, "کردستان" },
                    { 21, "کرمان" },
                    { 22, "کرمانشاه" },
                    { 23, "کهگیلویه و بویراحمد" },
                    { 24, "گلستان" },
                    { 25, "گیلان" },
                    { 26, "لرستان" },
                    { 27, "مازندران" },
                    { 28, "مرکزی" },
                    { 29, "هرمزگان" },
                    { 30, "همدان" },
                    { 31, "یزد" }
                });

            migrationBuilder.InsertData(
                table: "HomeServiceCategories",
                columns: new[] { "Id", "Description", "IsDeleted", "Name", "RegisterDate", "Title" },
                values: new object[,]
                {
                    { 1, null, false, "دکوراسیون ساختمان", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4108), null },
                    { 2, null, false, "تاسیسات ساختمان", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4149), null },
                    { 3, null, false, "وسایل نقلیه", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4152), null },
                    { 4, null, false, "اسباب کشی و باربری", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4154), null },
                    { 5, null, false, "لوازم خانگی", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4156), null },
                    { 6, null, false, "خدمات اداری", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4158), null },
                    { 7, null, false, "نظافت و بهداشت", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4159), null },
                    { 8, null, false, "دیجیتال و نرم افزار", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4161), null },
                    { 9, null, false, "پزشکی و سلامت", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(4164), null }
                });

            migrationBuilder.InsertData(
                table: "HomeServiceSubCategories",
                columns: new[] { "Id", "HomeServiceCategoryId", "IsDeleted", "Name", "RegisterDate" },
                values: new object[,]
                {
                    { 1, 1, false, "بنایی", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5514) },
                    { 2, 1, false, "دکوراسیون", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5526) },
                    { 3, 1, false, "نقاشی ساختمان", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5528) },
                    { 4, 1, false, "درب و پنجره", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5530) },
                    { 5, 1, false, "آهنگری و جوشکاری", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5531) },
                    { 6, 1, false, "باغبانی", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5533) },
                    { 7, 2, false, "سرمایش و گرمایش", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5534) },
                    { 8, 2, false, "لوله کشی", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5537) },
                    { 9, 2, false, "برق و الکترونیک", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5538) },
                    { 10, 2, false, "تلفن و سانترال", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5540) },
                    { 11, 3, false, "خودرو", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5542) },
                    { 12, 4, false, "اسباب کشی", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5543) },
                    { 13, 4, false, "حمل بار", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5545) },
                    { 14, 5, false, "لوازم آشپزخانه", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5547) },
                    { 15, 5, false, "لوازم شست و شو و نظافت", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5548) },
                    { 16, 5, false, "لوازم صوتی و تصویری", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5550) },
                    { 17, 6, false, "ماشین اداری", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5551) },
                    { 18, 6, false, "مبلمان اداری", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5553) },
                    { 19, 7, false, "نظافت", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5555) },
                    { 20, 7, false, "خشکشویی و اتوشویی", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5556) },
                    { 21, 7, false, "قالیشویی و مبل شویی", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5558) },
                    { 22, 7, false, "سمپاشی", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5560) },
                    { 23, 8, false, "موبایل و تبلت", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5561) },
                    { 24, 8, false, "خدمات کامپیوتری", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5563) },
                    { 25, 8, false, "امنیت و شبکه", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5564) },
                    { 26, 9, false, "پزشکی", new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5566) }
                });

            migrationBuilder.InsertData(
                table: "HomeServices",
                columns: new[] { "Id", "BasePrice", "Description", "HomeServiceSubCategoryId", "ImgSrc", "IsDeleted", "Name", "Price", "RegisterDate" },
                values: new object[,]
                {
                    { 1, 0.0, null, 1, "2ce018e0-9826-4003-bcfa-3ddacc7d37b0.avif", false, "کاشی و سرامیک", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5921) },
                    { 2, 0.0, null, 1, "e7472819-17a4-4d71-827a-89289c031373.avif", false, "بنایی ساختمان", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5930) },
                    { 3, 0.0, null, 1, "34b130ba-5bf6-4ca4-8d34-f8071d707ff8.avif", false, "گچ کاری", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5933) },
                    { 4, 0.0, null, 1, "35de9364-d86b-4fdb-8758-31e89a7305f5.avif", false, "کارگر ساده", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5935) },
                    { 5, 0.0, null, 1, "2cd703db-36aa-4921-9f12-0033d6b44ffe.avif", false, "بازسازی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5937) },
                    { 6, 0.0, null, 1, "b6b376ac-3bcf-48a3-b055-6a7c20dd4dd0.avif", false, "کانال سازی و دریچه کولر", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5942) },
                    { 7, 0.0, null, 1, "dac1bb2d-374d-4ef9-8de2-bb2f1082714b.avif", false, "عایق کاری و ایزوگام", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5944) },
                    { 8, 0.0, null, 1, "a264b5eb-c52a-42d0-b70b-db5091869be7.avif", false, "سنگ کاری", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5946) },
                    { 9, 0.0, null, 1, "a845202d-032c-406a-b8c9-b07217340951.avif", false, "سیمان کاری", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5948) },
                    { 10, 0.0, null, 2, "f172da2f-9444-4891-b693-03099e238fbc.avif", false, "نقاشی ساختمان", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5950) },
                    { 11, 0.0, null, 2, "1498af45-eef9-4b71-a733-42a6b62b3ee7.avif", false, "کابینت", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5952) },
                    { 12, 0.0, null, 2, "a836a67f-da40-4a4c-905e-48bf386d4726.avif", false, "کاغذ دیواری", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5954) },
                    { 13, 0.0, null, 2, "ea35c1c1-c87e-403a-811f-a04ed5da8224.avif", false, "نجاری", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5956) },
                    { 14, 0.0, null, 2, "8dfe930c-1ed7-4592-855e-252c3105e237.avif", false, "کفسابی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5958) },
                    { 15, 0.0, null, 2, "d6724f46-cb4c-4f4f-bd3f-2c1fec484043.avif", false, "کفپوش", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5960) },
                    { 16, 0.0, null, 2, "4407bd89-224a-4967-bef7-39e337936d23.avif", false, "پارکت", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5962) },
                    { 17, 0.0, null, 2, "844dedd7-0876-4a81-bc4c-ff6beddafa06.avif", false, "لمینت", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5964) },
                    { 18, 0.0, null, 2, "7a30dcfa-8d95-4759-84fb-2b211ac4b4ed.avif", false, "موکت", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5965) },
                    { 19, 0.0, null, 2, "ed828d72-5110-40b3-8a53-be2f8ed4bb7f", false, "دوخت پرده", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5967) },
                    { 20, 0.0, null, 2, "4d79e2a7-edac-473c-9753-543225e70346.avif", false, "مبلمان", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5969) },
                    { 21, 0.0, null, 2, "329f3061-42b5-428f-b793-5f6362631cc4.avif", false, "سرویس خواب", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5971) },
                    { 22, 0.0, null, 2, "30fda66e-b645-46bf-8f50-135ab117e695.avif", false, "سقف کاذب", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5973) },
                    { 23, 0.0, null, 3, "8e0d0856-315f-43f3-907a-3c2271f10628.avif", false, "نمای ساختمان", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5975) },
                    { 24, 0.0, null, 3, "3e8e8c0f-99eb-44d1-ab2a-b1db73e666bb.avif", false, "تعمیر نمای ساختمان", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5977) },
                    { 25, 0.0, null, 4, "ff709f66-fbb0-47e9-a622-106e4a1b0d03.avif", false, "شیشه بری", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5979) },
                    { 26, 0.0, null, 4, "554b399f-6347-40c6-aaae-a11d173766ad.avif", false, "توری پنجره", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5981) },
                    { 27, 0.0, null, 4, "6d3e0935-6c7c-4a7b-92c8-bff55e6ddcbe.avif", false, "نصب درب چوبی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5984) },
                    { 28, 0.0, null, 5, "35cb61d4-637a-4cc7-96a2-34e39782bf96.avif", false, "جوشکاری و آهنگری", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5986) },
                    { 29, 0.0, null, 5, "d01f38eb-92ed-4a75-93b1-e512ee485d93.avif", false, "کلید سازی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(5988) },
                    { 30, 0.0, null, 6, "7b9f726c-0d1b-4d80-8bdd-1da5d4ddfeb6.avif", false, "گل و گیاه آپارتمانی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6021) },
                    { 31, 0.0, null, 6, "b86725c4-2d69-4911-af66-74ba8eaf0a2c.avif", false, "باغبانی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6024) },
                    { 32, 0.0, null, 7, "dbad83e3-bee2-4780-b52d-07850e7875da.avif", false, "کولر آبی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6026) },
                    { 33, 0.0, null, 7, "8b54a660-e292-4be8-8599-3157f26821af.avif", false, "کولر گازی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6028) },
                    { 34, 0.0, null, 7, "f91f1891-59c9-4f98-a187-0b0f7df31ae6.avif", false, "پکیج", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6030) },
                    { 35, 0.0, null, 7, "c09a0de0-0565-4c90-a9f7-250b6ca8b5f1.avif", false, "آبگرمکن", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6032) },
                    { 36, 0.0, null, 7, "3a603b3a-ef24-4c08-9034-9900b0c3b210.avif", false, "فن‌کویل", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6034) },
                    { 37, 0.0, null, 7, "5809f193-9a69-4a50-8bb7-a2a8bede30d6.avif", false, "چیلر و هواساز", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6036) },
                    { 38, 0.0, null, 7, "210f7785-befe-4844-9b4a-fd569f581e0c.avif", false, "رادیاتور شوفاژ", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6038) },
                    { 39, 0.0, null, 7, "33647fdc-9293-4b5d-8c95-d460631d4d96.avif", false, "موتورخانه", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6040) },
                    { 40, 0.0, null, 7, "2a4a15fb-bcca-4080-aca6-48b56490503c.avif", false, "بخاری گازی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6042) },
                    { 41, 0.0, null, 7, "0dfa16d5-03dc-4792-97b2-a2c53af7d7dc.avif", false, "شومینه گازی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6044) },
                    { 42, 0.0, null, 8, "3d246b0d-4045-4bca-a5d9-6fe88ce95d1e.avif", false, "لوله کشی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6045) }
                });

            migrationBuilder.InsertData(
                table: "HomeServices",
                columns: new[] { "Id", "BasePrice", "Description", "HomeServiceSubCategoryId", "ImgSrc", "IsDeleted", "Name", "Price", "RegisterDate" },
                values: new object[,]
                {
                    { 43, 0.0, null, 8, "dc83b92f-188b-4763-8113-cfea3b7bc885.avif", false, "شیرآلات ساختمانی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6047) },
                    { 44, 0.0, null, 8, "7b297bb6-8ed8-4302-a4ad-a72859c53a74.avif", false, "لوله بازکنی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6049) },
                    { 45, 0.0, null, 8, "9fd2a021-c0f0-4c62-af06-52b54b7bd9a6.avif", false, "توالت فرنگی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6051) },
                    { 46, 0.0, null, 8, "9a0b0bb3-b077-4f75-817c-3e7b35889acb.avif", false, "پمپ آب", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6053) },
                    { 47, 0.0, null, 8, "46364dd7-c2a5-4e9e-bc05-8d2c11e2f3cc.avif", false, "لوله‌ کشی گاز", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6055) },
                    { 48, 0.0, null, 8, "fe75e004-e7cd-4db1-800b-5d5a797a75bf.avif", false, "تخلیه چاه", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6057) },
                    { 49, 0.0, null, 8, "1a9ce365-a1bf-4e98-8579-18d4fbd22667.avif", false, "فلاش تانک", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6060) },
                    { 50, 0.0, null, 8, "0c653840-4235-468b-a0ee-3a2eb24b1058.avif", false, "روشویی و دست‌شور", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6062) },
                    { 51, 0.0, null, 8, "a6fed297-3438-43d8-94f2-e25c8e6e0533.avif", false, "سینک ظرفشویی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6064) },
                    { 52, 0.0, null, 9, "1e72d779-6c79-40c9-bd8b-051db9cd5ec5.avif", false, "برق کاری ساختمان", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6065) },
                    { 53, 0.0, null, 9, "8d5cc788-6dbd-45e4-84f0-84308c7a21b0.avif", false, "آیفون تصویری", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6067) },
                    { 54, 0.0, null, 9, "9ed35b07-753a-43cb-aed8-3bc8dc757638.avif", false, "لوستر", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6069) },
                    { 55, 0.0, null, 9, "706e32b5-a1af-4363-91c3-fb2cfb612905.avif", false, "دوربین مداربسته", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6071) },
                    { 56, 0.0, null, 9, "a3aea78f-a04f-4198-87e2-a85ad73e91ea.avif", false, "هواکش", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6073) },
                    { 57, 0.0, null, 9, "02d218f0-1be8-45e3-9aa1-939768f70591.avif", false, "آنتن دیجیتال", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6075) },
                    { 58, 0.0, null, 9, "b384f9cf-023d-405f-9763-b38da76ddbe8.avif", false, "نورپردازی ساختمان", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6077) },
                    { 59, 0.0, null, 9, "c5e8e489-1cb1-4126-8b41-5aeda52f3aaf.avif", false, "تایمر مشاعات", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6079) },
                    { 60, 0.0, null, 9, "6432de25-5492-4eb6-850f-b0d77af90d1b.avif", false, "جعبه فیوز", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6081) },
                    { 61, 0.0, null, 9, "51d9a954-77c2-4ef8-b0de-8f5d09160e8e.avif", false, "داکت کشی و ترانکینگ", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6083) },
                    { 62, 0.0, null, 10, "36d05574-0b49-4a99-adb3-6dc22577b8d2.avif", false, "سیم کشی تلفن", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6085) },
                    { 63, 0.0, null, 10, "16925f86-c028-4899-aa40-069f31d47b55.avif", false, "سیم کشی سانترال", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6087) },
                    { 64, 0.0, null, 11, "7583b4a7-2ed5-4699-8bde-f416e78dd226.avif", false, "صافکاری و نقاشی خودرو", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6089) },
                    { 65, 0.0, null, 11, "0258e8d5-9668-4893-8d15-0183145d0fab.avif", false, "تعویض روغن", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6091) },
                    { 66, 0.0, null, 11, "454eca89-8ba7-4fbf-9270-2aeb3fc4879f.avif", false, "تعمیر خودرو", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6092) },
                    { 67, 0.0, null, 11, "7014ff29-f51c-4e56-83b7-32f78341c1e4.avif", false, "برق خودرو", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6094) },
                    { 68, 0.0, null, 12, "15b1016e-eede-448d-8a3e-c832030d4507.avif", false, "اسباب کشی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6096) },
                    { 69, 0.0, null, 13, "d7946c6f-43bb-4ad5-8684-043e70fed7f7.avif", false, "حمل بار ", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6098) },
                    { 70, 0.0, null, 14, "3a805751-f8ce-47fd-8e78-0429ee6a4c52.avif", false, "یخچال", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6101) },
                    { 71, 0.0, null, 14, "69c43dcd-d644-4156-8e0f-06002ad6b3e8.avif", false, "ماشین ظرفشویی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6102) },
                    { 72, 0.0, null, 14, "83bdaeea-f908-405b-9208-eeddbed88c5e.avif", false, "مایکروفر", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6104) },
                    { 73, 0.0, null, 14, "4e58b3cb-36de-43a4-83e0-72632d1e1e86.avif", false, "اجاق برقی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6106) },
                    { 74, 0.0, null, 14, "4df97a51-4335-4863-86de-1cc0bee8356d.avif", false, "هود آشپزخانه", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6108) },
                    { 75, 0.0, null, 14, "0b84d3f6-89d4-4873-9157-b2d9fc2f51c5.avif", false, "اجاق گاز", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6110) },
                    { 76, 0.0, null, 15, "aded05f5-8c4b-451b-b58f-d692c6e08d84.avif", false, "ماشین لباسشویی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6112) },
                    { 77, 0.0, null, 15, "7f227268-ba59-457b-afcb-dd76a256d07d.avif", false, "اتو بخار", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6114) },
                    { 78, 0.0, null, 15, "35bc08ad-7f9c-4a10-8ea6-c5f9edf9ea0e.avif", false, "اتو پرس", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6116) },
                    { 79, 0.0, null, 15, "d04efd6a-2c16-4e57-afb1-cdaaccf91427.avif", false, "جاروبرقی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6118) },
                    { 80, 0.0, null, 15, "a01bef88-058c-4caf-ad4a-7fedcedf9ba6.avif", false, "جارو شارژی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6120) },
                    { 81, 0.0, null, 16, "4c7b8c4e-c292-486c-bf1a-0d15e551c0e8.avif", false, "تلویزیون", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6121) },
                    { 82, 0.0, null, 16, "cb580eff-96fb-4ecd-bc3a-39e43c9e7062.avif", false, "سینما خانگی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6123) },
                    { 83, 0.0, null, 17, "587fb9ab-11ca-4e29-a6f2-0404ca1c1ef2.avif", false, "دستگاه کپی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6125) },
                    { 84, 0.0, null, 17, "88e26199-0184-4b06-865b-dfab22950800.avif", false, "فکس", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6127) }
                });

            migrationBuilder.InsertData(
                table: "HomeServices",
                columns: new[] { "Id", "BasePrice", "Description", "HomeServiceSubCategoryId", "ImgSrc", "IsDeleted", "Name", "Price", "RegisterDate" },
                values: new object[,]
                {
                    { 85, 0.0, null, 17, "7296d9ec-b48d-4225-bb36-23ceb5d75888.avif", false, "پرینتر", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6130) },
                    { 86, 0.0, null, 18, "15dd3bcd-8c99-496c-b53d-a4c6be1f7cf1.avif", false, "پارتیشن اداری", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6131) },
                    { 87, 0.0, null, 19, "d35afbab-349a-40a5-9920-c7aaf0088bf8.avif", false, "نظافت دوره ای", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6133) },
                    { 88, 0.0, null, 19, "53b6758b-6df7-4149-a1fb-179f8c14fe69.avif", false, "نظافت منزل", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6135) },
                    { 89, 0.0, null, 19, "428cfcf0-6cbb-4fc5-a425-24950f13c60d.avif", false, "نظافت ساختمان", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6137) },
                    { 90, 0.0, null, 19, "12b6bd85-b5fb-4a6e-b3ef-6f4a7393601d.avif", false, "نظافت شرکت و اداره", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6183) },
                    { 91, 0.0, null, 19, "eb16cbf2-f8ef-4bcc-99fc-1ce8a42b7f5f.avif", false, "ضدعفونی منزل و محل کار", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6186) },
                    { 92, 0.0, null, 20, "6e672608-99a6-4f78-88b1-380fc3a884ba.avif", false, "خشکشویی آنلاین", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6188) },
                    { 93, 0.0, null, 20, "a08223f4-a911-41d9-9efc-6173f7771021.avif", false, "خشکشویی پرده", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6190) },
                    { 94, 0.0, null, 21, "65dc2285-4c94-4a31-aa6e-bb8000fc9402.avif", false, "قالیشویی آنلاین", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6192) },
                    { 95, 0.0, null, 21, "3e8bf209-ea00-40a5-992c-b5e360bab4fb.avif", false, "مبل شویی", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6194) },
                    { 96, 0.0, null, 22, "2fd6426a-ee1a-4bf3-befb-0fa5f3c17885.avif", false, "سمپاشی منازل", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6195) },
                    { 97, 0.0, null, 23, "958a54ca-c84f-47f2-8b66-7b84de6d9d2d.avif", false, "تعمیر موبایل", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6197) },
                    { 98, 0.0, null, 24, "8ddec483-9b8d-4fc9-8a39-987a4ab03873.avif", false, "تعمیر لپ‌تاپ", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6199) },
                    { 99, 0.0, null, 24, "c068e5dd-bcaf-4b83-b9dd-9bfbb060c4e7.avif", false, "تعمیر سخت افزار کامپیوتر", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6201) },
                    { 100, 0.0, null, 24, "f7fb5686-f130-4f13-86a0-b6f79d0ce790.avif", false, "نصب نرم افزار", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6203) },
                    { 101, 0.0, null, 24, "f2d25592-d8c4-4430-badc-839a2fa9eff0.avif", false, "نصب ویندوز در محل", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6205) },
                    { 102, 0.0, null, 25, "7eeea6b2-0a32-4aa5-8244-7f84bcfe200e.avif", false, "تعمیر مودم اینترنت", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6207) },
                    { 103, 0.0, null, 25, "6d22ccda-5eda-48dd-bb26-4095c48447af.avif", false, "راه‌ اندازی شبکه کامپیوتری", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6209) },
                    { 104, 0.0, null, 26, "c214ac59-9605-48b4-95bf-1b12a79d870c.avif", false, "آزمایش در محل", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6210) },
                    { 105, 0.0, null, 26, "9d49d3fc-88fe-4fd8-bd12-eba51013a8d6.avif", false, "پرستاری در منزل", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6212) },
                    { 106, 0.0, null, 26, "3f4df8f1-7e51-4d57-b98a-568f1eef5396.avif", false, "ویزیت پزشک در منزل", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6214) },
                    { 107, 0.0, null, 26, "f73d4d27-3e0b-422e-bad2-deebd9d0467d.avif", false, "نوار قلب در محل", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6216) },
                    { 108, 0.0, null, 26, "64bd6636-1560-4dd6-9499-c72dde33b07e.avif", false, "فیزیوتراپی در منزل", 0.0, new DateTime(2022, 7, 19, 20, 39, 39, 763, DateTimeKind.Local).AddTicks(6218) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ExpertId",
                table: "Comments",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ApplicationUserId",
                table: "Customers",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityId",
                table: "Customers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertHomeService_HomeServicesId",
                table: "ExpertHomeService",
                column: "HomeServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Experts_ApplicationUserId",
                table: "Experts",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Experts_CityId",
                table: "Experts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeServices_HomeServiceSubCategoryId",
                table: "HomeServices",
                column: "HomeServiceSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeServiceSubCategories_HomeServiceCategoryId",
                table: "HomeServiceSubCategories",
                column: "HomeServiceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_OrderId",
                table: "Images",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderFiles_OrderId",
                table: "OrderFiles",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_HomeServiceId",
                table: "Orders",
                column: "HomeServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestions_ExpertId",
                table: "Suggestions",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestions_OrderId",
                table: "Suggestions",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ExpertHomeService");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderFiles");

            migrationBuilder.DropTable(
                name: "Suggestions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "HomeServices");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "HomeServiceSubCategories");

            migrationBuilder.DropTable(
                name: "HomeServiceCategories");
        }
    }
}
