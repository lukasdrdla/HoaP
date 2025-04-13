using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CustomerRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerRoles_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e6b6628-893d-4541-8b63-77ed829aadca", null, "", "Receptionist", "RECEPTIONIST" },
                    { "a774adf1-c520-435d-97ab-0ef3d4969bce", null, "", "Admin", "ADMIN" },
                    { "f4c89087-e64a-440a-9922-13dae8f3230f", null, "", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2825a9c8-d3d3-43d0-aea8-27374a758135", 0, "Hlavní 123", "Praha", "743bec55-89b6-4619-a018-d3af40ba42e6", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENgs2KWWk8JzOvQugg/fCxYCSwAzMe/z9ZD/rgOPAva8gSMUA5Ib5Kj79mTNktg4vQ==", "CZ1234567890", null, false, "Praha", "11000", null, 50000m, "b44776ca-cd89-4c18-8fa5-534e49c82513", new DateTime(2025, 4, 12, 15, 34, 56, 238, DateTimeKind.Local).AddTicks(9359), false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4444), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4452), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4459), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4466), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4473), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4481), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4488), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4495), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4502), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4509), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4599), new DateTime(2025, 5, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4597), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4596), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4607), new DateTime(2025, 5, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4606), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4605), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4614), new DateTime(2025, 5, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4613), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4612), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4621), new DateTime(2025, 5, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4620), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4619), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4628), new DateTime(2025, 5, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4627), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4626), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4542), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4548), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4553), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4559), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4565), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4330), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4347), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4350), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4352), new DateTime(2025, 4, 12, 15, 34, 56, 274, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRoles_CustomerId",
                table: "CustomerRoles",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerRoles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e6b6628-893d-4541-8b63-77ed829aadca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a774adf1-c520-435d-97ab-0ef3d4969bce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4c89087-e64a-440a-9922-13dae8f3230f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2825a9c8-d3d3-43d0-aea8-27374a758135");

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
    }
}
