using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImageUploads : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e60bbbe-0ede-4ce9-886c-2f117fedf2de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a6975b3-e18a-416a-a3eb-11bd189d6856");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e460fb53-669c-4f46-9da9-7543b12cb61b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84edb0c5-4e10-484a-a3ed-22cedf366026");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Rooms",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<byte[]>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21b65fd4-a43e-4916-8017-6802187daec6", null, "", "Receptionist", "RECEPTIONIST" },
                    { "aca2511d-8d0e-4009-a7c8-780458eb3b96", null, "", "Admin", "ADMIN" },
                    { "f0b4e8d6-17a9-42ee-b0e9-b8370bf2d6b8", null, "", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5255f1ee-e825-499b-afa1-0e3e95fd371e", 0, "Hlavní 123", "Praha", "c953f521-2579-475b-86b3-52b49957b8f8", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENDUlOQoJehGlozfOVzeOl9LuvSaonB81zmfT+tn41dNrHErMnxtxVHq2WQOgKHYnA==", "CZ1234567890", null, false, "Praha", "11000", null, 50000m, "1a208886-7b1b-4c0d-bec2-500b234dc07a", new DateTime(2025, 2, 9, 11, 30, 17, 382, DateTimeKind.Local).AddTicks(6275), false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4672), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4682), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4692), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4700), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4709), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4718), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4726), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4735), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4743), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4752), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4888), new DateTime(2025, 3, 11, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4886), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4884), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4897), new DateTime(2025, 3, 11, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4895), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4894), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4905), new DateTime(2025, 3, 11, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4904), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4903), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4914), new DateTime(2025, 3, 11, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4913), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4912), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4923), new DateTime(2025, 3, 11, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4921), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4920), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4798), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4827), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4834), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4841), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4848), new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Image", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4564), null, new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Image", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4619), null, new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Image", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4622), null, new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Image", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4625), null, new DateTime(2025, 2, 9, 11, 30, 17, 419, DateTimeKind.Local).AddTicks(4626) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21b65fd4-a43e-4916-8017-6802187daec6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca2511d-8d0e-4009-a7c8-780458eb3b96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0b4e8d6-17a9-42ee-b0e9-b8370bf2d6b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5255f1ee-e825-499b-afa1-0e3e95fd371e");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Rooms",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e60bbbe-0ede-4ce9-886c-2f117fedf2de", null, "", "Receptionist", "RECEPTIONIST" },
                    { "3a6975b3-e18a-416a-a3eb-11bd189d6856", null, "", "Admin", "ADMIN" },
                    { "e460fb53-669c-4f46-9da9-7543b12cb61b", null, "", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "84edb0c5-4e10-484a-a3ed-22cedf366026", 0, "Hlavní 123", "Praha", "4d5a57c2-5e79-4b15-a12b-e941ede4d3db", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJJfWr9s9Fdiw/TPmXT02LwvEKvjEj4V1jO4Q9nRhrH3EES7gwq/UGYxUQ/sl6U2Bw==", "CZ1234567890", null, false, "Praha", "11000", "default.jpg", 50000m, "1c476995-64d9-4d20-8f24-b1bd1800698b", new DateTime(2025, 1, 30, 11, 7, 21, 775, DateTimeKind.Local).AddTicks(3414), false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2088), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2095), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2102), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2109), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2115), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2123), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2130), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2136), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2144), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2150), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2242), new DateTime(2025, 3, 1, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2240), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2240), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2250), new DateTime(2025, 3, 1, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2248), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2248), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2256), new DateTime(2025, 3, 1, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2255), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2254), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2263), new DateTime(2025, 3, 1, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2262), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2262), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2270), new DateTime(2025, 3, 1, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2269), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2268), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2186), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2192), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2198), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2204), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2209), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Image", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(1993), "", new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Image", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2046), "", new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Image", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2049), "", new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Image", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2052), "", new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2053) });
        }
    }
}
