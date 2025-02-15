using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixReservationRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11555f5b-7bdc-4fc6-b2ef-77481b1336be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9312f03c-e572-4cdf-8c7f-289552bc02c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8d39f82-54d6-4e61-87c6-2f89dc566aa1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19329d22-ce24-42ab-a8d7-db7255a28384");

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "Reservations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedAt", "IsCanceled", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7445), false, new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsCanceled", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7451), false, new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsCanceled", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7457), false, new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsCanceled", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7462), false, new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsCanceled", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7468), false, new DateTime(2025, 2, 13, 15, 56, 47, 246, DateTimeKind.Local).AddTicks(7469) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "Reservations");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11555f5b-7bdc-4fc6-b2ef-77481b1336be", null, "", "Receptionist", "RECEPTIONIST" },
                    { "9312f03c-e572-4cdf-8c7f-289552bc02c2", null, "", "Admin", "ADMIN" },
                    { "e8d39f82-54d6-4e61-87c6-2f89dc566aa1", null, "", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "19329d22-ce24-42ab-a8d7-db7255a28384", 0, "Hlavní 123", "Praha", "06301ce2-930a-46bb-96db-9870eb5aaab0", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENY2mv1A/0bDdONUysTG4Jos7xQP6vPFhum82MRIfpUAcwYxwbm8THkGRTUloRiqXQ==", "CZ1234567890", null, false, "Praha", "11000", null, 50000m, "7b3a268d-cb24-496e-94e2-2750c93f141c", new DateTime(2025, 2, 13, 15, 8, 47, 509, DateTimeKind.Local).AddTicks(956), false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5899), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5909), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5918), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5926), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5935), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5944), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5952), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6025), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6035), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6043), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6159), new DateTime(2025, 3, 15, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6157), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6155), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6168), new DateTime(2025, 3, 15, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6166), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6165), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6176), new DateTime(2025, 3, 15, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6175), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6174), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6185), new DateTime(2025, 3, 15, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6184), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6183), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6194), new DateTime(2025, 3, 15, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6193), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6192), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6092), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6099), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6106), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6113), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6120), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5766), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5834), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5837), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5840), new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5841) });
        }
    }
}
