using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a494304-654f-482f-8bf3-7570f7089d0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "878a5242-6d4b-49dc-889f-db176a8520eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec1f1014-28d8-45b5-b814-fd245d22c1b0");

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(1993), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2046), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2049), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2052), new DateTime(2025, 1, 30, 11, 7, 21, 811, DateTimeKind.Local).AddTicks(2053) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a494304-654f-482f-8bf3-7570f7089d0c", null, "", "Receptionist", "RECEPTIONIST" },
                    { "878a5242-6d4b-49dc-889f-db176a8520eb", null, "", "Admin", "ADMIN" },
                    { "ec1f1014-28d8-45b5-b814-fd245d22c1b0", null, "", "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6439), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6447), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6454), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6461), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6468), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6474), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6481), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6488), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6495), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6502), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6582), new DateTime(2025, 2, 19, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6581), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6579), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6591), new DateTime(2025, 2, 19, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6590), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6589), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6598), new DateTime(2025, 2, 19, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6597), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6596), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6605), new DateTime(2025, 2, 19, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6604), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6603), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6612), new DateTime(2025, 2, 19, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6611), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6610), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6531), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6537), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6543), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6548), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6554), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6341), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6400), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6403), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6405), new DateTime(2025, 1, 20, 16, 29, 56, 713, DateTimeKind.Local).AddTicks(6406) });
        }
    }
}
