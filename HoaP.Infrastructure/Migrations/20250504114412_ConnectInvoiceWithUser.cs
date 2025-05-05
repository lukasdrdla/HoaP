using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConnectInvoiceWithUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "373adebe-c649-4a05-bcbc-236a9ee5a7d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aba93b6-3b38-45e7-b3fb-b1fef810bb0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b43052d1-688c-4300-8ffa-45fc6ab9c339");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8c00ec3-aa0b-4cd7-8b90-1de39b46599f");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Invoices",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_AppUserId",
                table: "Invoices",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_AspNetUsers_AppUserId",
                table: "Invoices",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_AspNetUsers_AppUserId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_AppUserId",
                table: "Invoices");

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

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Invoices");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "373adebe-c649-4a05-bcbc-236a9ee5a7d8", null, "", "Manager", "MANAGER" },
                    { "7aba93b6-3b38-45e7-b3fb-b1fef810bb0f", null, "", "Receptionist", "RECEPTIONIST" },
                    { "b43052d1-688c-4300-8ffa-45fc6ab9c339", null, "", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f8c00ec3-aa0b-4cd7-8b90-1de39b46599f", 0, "Hlavní 123", "Praha", "0042294a-1302-4476-9d82-a85b0d3ce5bc", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEN/p0rcKqYxqYNCNC2Dtg7PnVN6vs8Do97Gf+2IxTunHEGKP9WNF8DtvvmNjrDIegQ==", "CZ1234567890", null, false, "Praha", "11000", null, 50000m, "310f980b-cdc1-4938-ac83-1029b15a1be6", new DateTime(2025, 4, 12, 15, 44, 43, 872, DateTimeKind.Local).AddTicks(2124), false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9658), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9666), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9673), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9680), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9687), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9694), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9701), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9708), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9716), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9722), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9827), new DateTime(2025, 5, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9826), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9824), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9857), new DateTime(2025, 5, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9856), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9855), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9865), new DateTime(2025, 5, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9864), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9863), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9872), new DateTime(2025, 5, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9871), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9870), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9879), new DateTime(2025, 5, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9878), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9877), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9766), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9773), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9779), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9785), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9790), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9558), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9608), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9611), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9614), new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9615) });
        }
    }
}
