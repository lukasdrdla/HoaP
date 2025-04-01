using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGeneralizationTKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c7d7b70-e256-4567-af11-cbe6ccb2686f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "453c9cdc-5b7f-4246-a3b1-2e419228373f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7688477d-106a-49b3-a893-da38e310e129");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8830415-0dce-4d8c-b10e-029360645962");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c7950ef-0f04-4ffa-85e6-ea228ce82646", null, "", "Admin", "ADMIN" },
                    { "35217d5e-afbc-4635-bee3-aa43d3482de7", null, "", "Receptionist", "RECEPTIONIST" },
                    { "fc6c51e1-e4e5-4d8e-b8a5-5b18b1412452", null, "", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f29c0038-38e2-4d77-a444-2074bb73c08c", 0, "Hlavní 123", "Praha", "f94ac1f7-d75c-4f48-af04-362b8f7e859c", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJ4fnyaIR44lUC2E+Q2R/zobgZF5PYE7vQ/cnDmYKG17iwkjVAfyjf5vOan8rp4Dpg==", "CZ1234567890", null, false, "Praha", "11000", null, 50000m, "c5bd99cc-21e9-4cbd-ba14-a343d6f344ec", new DateTime(2025, 2, 15, 19, 26, 52, 31, DateTimeKind.Local).AddTicks(3765), false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7773), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7780), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7787), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7794), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7801), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7808), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7815), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7822), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7829), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7836), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7932), new DateTime(2025, 3, 17, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7930), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7929), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7940), new DateTime(2025, 3, 17, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7938), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7938), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7947), new DateTime(2025, 3, 17, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7946), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7945), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7954), new DateTime(2025, 3, 17, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7953), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7952), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7961), new DateTime(2025, 3, 17, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7960), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7959), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7875), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7881), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7887), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7892), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7898), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7678), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7727), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7729), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7732), new DateTime(2025, 2, 15, 19, 26, 52, 67, DateTimeKind.Local).AddTicks(7732) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c7950ef-0f04-4ffa-85e6-ea228ce82646");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35217d5e-afbc-4635-bee3-aa43d3482de7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc6c51e1-e4e5-4d8e-b8a5-5b18b1412452");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f29c0038-38e2-4d77-a444-2074bb73c08c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c7d7b70-e256-4567-af11-cbe6ccb2686f", null, "", "Admin", "ADMIN" },
                    { "453c9cdc-5b7f-4246-a3b1-2e419228373f", null, "", "Manager", "MANAGER" },
                    { "7688477d-106a-49b3-a893-da38e310e129", null, "", "Receptionist", "RECEPTIONIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b8830415-0dce-4d8c-b10e-029360645962", 0, "Hlavní 123", "Praha", "a466a3c7-d23c-41e5-bceb-73265f8ae9e4", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEAgcn6Qj/YVvtHEB2iO+cRY8CMwF7vcVkK6vxkLYCSnABC920/OyQ1j4fE7iEaYNiA==", "CZ1234567890", null, false, "Praha", "11000", null, 50000m, "22e6cca6-0822-4eb9-9a31-41d7cf0e5c7c", new DateTime(2025, 2, 13, 15, 56, 47, 210, DateTimeKind.Local).AddTicks(4764), false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7340), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7348), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7356), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7363), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7370), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7377), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7383), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7390), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7397), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7404), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7505), new DateTime(2025, 3, 15, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7501), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7499), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7512), new DateTime(2025, 3, 15, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7511), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7510), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7519), new DateTime(2025, 3, 15, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7518), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7517), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7526), new DateTime(2025, 3, 15, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7525), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7524), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7533), new DateTime(2025, 3, 15, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7532), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7531), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7445), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7451), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7457), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7462), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7468), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7226), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7285), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7289), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7291), new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7292) });
        }
    }
}
