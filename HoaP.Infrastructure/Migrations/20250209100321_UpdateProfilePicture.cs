using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProfilePicture : Migration
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
                    { "02cf4dae-7720-495f-bb73-b8e6f234a5f4", null, "", "Manager", "MANAGER" },
                    { "afa3575a-b794-46ed-82f9-83306be7f682", null, "", "Receptionist", "RECEPTIONIST" },
                    { "bbc4eeaf-3244-465e-8de5-fa1df92773af", null, "", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ddf81b1e-f046-48d5-a488-91bfc721088e", 0, "Hlavní 123", "Praha", "c6134d6d-9773-405b-a90a-ae3299fbfb27", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEI/goBV0vdt/swVdpDNF99QzNmuz3SvgcSif+S//Y5N0y5C82PTfrfDCoRg7qtB/gA==", "CZ1234567890", null, false, "Praha", "11000", null, 50000m, "f93f5319-0893-4cb4-a98c-c3a0edd49e8e", new DateTime(2025, 2, 9, 11, 3, 21, 457, DateTimeKind.Local).AddTicks(4520), false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2800), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2809), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2816), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2823), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2831), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2838), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2845), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2852), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2859), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2866), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3041), new DateTime(2025, 3, 11, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3039), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3037), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3049), new DateTime(2025, 3, 11, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3047), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3046), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3056), new DateTime(2025, 3, 11, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3055), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3054), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3064), new DateTime(2025, 3, 11, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3062), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3062), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3071), new DateTime(2025, 3, 11, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3070), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3069), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2981), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2987), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2993), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2999), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3005), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2708), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2751), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2754), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2756), new DateTime(2025, 2, 9, 11, 3, 21, 494, DateTimeKind.Local).AddTicks(2757) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02cf4dae-7720-495f-bb73-b8e6f234a5f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afa3575a-b794-46ed-82f9-83306be7f682");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbc4eeaf-3244-465e-8de5-fa1df92773af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf81b1e-f046-48d5-a488-91bfc721088e");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Reviews");

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
    }
}
