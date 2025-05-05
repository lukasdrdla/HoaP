using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Rate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bfd261e-1ae3-4984-a7b5-3ce2f44bbf0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0f2dbb8-c02b-4a31-9925-4c55c578cf2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6fce52a-790c-418e-950c-8652c33eb929");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92dbdd5e-ce24-4e19-a90d-6b3a3192e38d");

            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "Currencies",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a67cbd1-2e37-4c1f-9012-6c541d4bd782", null, "", "Admin", "ADMIN" },
                    { "a23370c5-3c1a-4895-83e2-05a464d3a5b4", null, "", "Receptionist", "RECEPTIONIST" },
                    { "dd673cbf-4ed9-4adf-a42b-2b1ced87b388", null, "", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "69d591b1-ccd7-4d79-a892-1e15d2602880", 0, "Hlavní 123", "Praha", "4049a578-e727-491f-a273-b97e35e13425", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEE29vBWFHj9D+0jfX6WSO8FHkx+kMnFCCtuUX0if4GQTyS9qWXx7zYiBngnjmR8P8Q==", "CZ1234567890", null, false, "Praha", "11000", null, 50000m, "78e05373-c050-4223-8fcd-18426d54b6db", new DateTime(2025, 5, 5, 17, 37, 28, 60, DateTimeKind.Local).AddTicks(2087), false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rate",
                value: 1.0m);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rate",
                value: 1.0m);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Rate",
                value: 1.0m);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Rate",
                value: 1.0m);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Rate",
                value: 1.0m);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3002), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3010), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3017), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3025), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3031), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3039), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3046), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3053), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3060), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3067), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppUserId", "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { "69d591b1-ccd7-4d79-a892-1e15d2602880", new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3164), new DateTime(2025, 6, 4, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3163), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3161), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppUserId", "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { "69d591b1-ccd7-4d79-a892-1e15d2602880", new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3171), new DateTime(2025, 6, 4, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3170), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3169), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppUserId", "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { "69d591b1-ccd7-4d79-a892-1e15d2602880", new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3178), new DateTime(2025, 6, 4, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3177), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3176), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppUserId", "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { "69d591b1-ccd7-4d79-a892-1e15d2602880", new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3185), new DateTime(2025, 6, 4, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3184), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3184), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppUserId", "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { "69d591b1-ccd7-4d79-a892-1e15d2602880", new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3193), new DateTime(2025, 6, 4, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3192), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3191), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3105), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3111), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3118), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3123), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3129), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(2917), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(2960), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(2963), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(2965), new DateTime(2025, 5, 5, 17, 37, 28, 95, DateTimeKind.Local).AddTicks(2966) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a67cbd1-2e37-4c1f-9012-6c541d4bd782");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a23370c5-3c1a-4895-83e2-05a464d3a5b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd673cbf-4ed9-4adf-a42b-2b1ced87b388");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d591b1-ccd7-4d79-a892-1e15d2602880");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Currencies");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9bfd261e-1ae3-4984-a7b5-3ce2f44bbf0d", null, "", "Receptionist", "RECEPTIONIST" },
                    { "b0f2dbb8-c02b-4a31-9925-4c55c578cf2d", null, "", "Manager", "MANAGER" },
                    { "e6fce52a-790c-418e-950c-8652c33eb929", null, "", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "92dbdd5e-ce24-4e19-a90d-6b3a3192e38d", 0, "Hlavní 123", "Praha", "763a5948-9212-41b1-9846-97c87c456234", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEBhRHO9Z2kG3x55kzKNl9xBYWWGrcNKE4cfD1q6EWx8thWWcoGzGKtOGvaa3bpjxTA==", "CZ1234567890", null, false, "Praha", "11000", null, 50000m, "0aefa9ab-068b-4a74-83c0-6d038b3405dc", new DateTime(2025, 5, 4, 13, 44, 11, 990, DateTimeKind.Local).AddTicks(4017), false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4363), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4371), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4378), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4386), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4393), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4400), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4406), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4413), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4420), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4427), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppUserId", "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { "92dbdd5e-ce24-4e19-a90d-6b3a3192e38d", new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4524), new DateTime(2025, 6, 3, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4521), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4518), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppUserId", "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { "92dbdd5e-ce24-4e19-a90d-6b3a3192e38d", new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4532), new DateTime(2025, 6, 3, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4531), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4530), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppUserId", "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { "92dbdd5e-ce24-4e19-a90d-6b3a3192e38d", new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4539), new DateTime(2025, 6, 3, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4538), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4537), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppUserId", "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { "92dbdd5e-ce24-4e19-a90d-6b3a3192e38d", new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4547), new DateTime(2025, 6, 3, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4545), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4545), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppUserId", "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { "92dbdd5e-ce24-4e19-a90d-6b3a3192e38d", new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4554), new DateTime(2025, 6, 3, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4553), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4552), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4461), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4467), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4473), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4479), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4486), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4292), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4320), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4323), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4325), new DateTime(2025, 5, 4, 13, 44, 12, 25, DateTimeKind.Local).AddTicks(4326) });
        }
    }
}
