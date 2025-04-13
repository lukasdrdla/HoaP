using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixGuests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerRoles");

            migrationBuilder.DropTable(
                name: "Guests");

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

            migrationBuilder.AddColumn<bool>(
                name: "IsMainGuest",
                table: "Customers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ReservationCustomers",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IsMainGuest = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationCustomers", x => new { x.ReservationId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_ReservationCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationCustomers_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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
                columns: new[] { "CreatedAt", "IsMainGuest", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9658), false, new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsMainGuest", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9666), false, new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsMainGuest", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9673), false, new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsMainGuest", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9680), false, new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsMainGuest", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9687), false, new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsMainGuest", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9694), false, new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsMainGuest", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9701), false, new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsMainGuest", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9708), false, new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsMainGuest", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9716), false, new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsMainGuest", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9722), false, new DateTime(2025, 4, 12, 15, 44, 43, 907, DateTimeKind.Local).AddTicks(9723) });

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

            migrationBuilder.CreateIndex(
                name: "IX_ReservationCustomers_CustomerId",
                table: "ReservationCustomers",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationCustomers");

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

            migrationBuilder.DropColumn(
                name: "IsMainGuest",
                table: "Customers");

            migrationBuilder.CreateTable(
                name: "CustomerRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DocumentNumber = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guests_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_Guests_ReservationId",
                table: "Guests",
                column: "ReservationId");
        }
    }
}
