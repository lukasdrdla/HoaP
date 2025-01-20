using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAmenityToRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04cbec9d-ca49-4f85-b2cd-effb1b8a5f58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2671d59b-cae5-44bd-967c-4f39c966007a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcb68209-0574-4c35-ad67-f117afb0a49d");

            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Icon = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoomAmenities",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    AmenityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomAmenities", x => new { x.RoomId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_RoomAmenities_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomAmenities_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenities_AmenityId",
                table: "RoomAmenities",
                column: "AmenityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomAmenities");

            migrationBuilder.DropTable(
                name: "Amenities");

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
                    { "04cbec9d-ca49-4f85-b2cd-effb1b8a5f58", null, "", "Admin", "ADMIN" },
                    { "2671d59b-cae5-44bd-967c-4f39c966007a", null, "", "Manager", "MANAGER" },
                    { "bcb68209-0574-4c35-ad67-f117afb0a49d", null, "", "Receptionist", "RECEPTIONIST" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6004), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6012), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6019), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6026), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6033), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6040), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6047), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6054), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6061), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6068), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6198), new DateTime(2025, 2, 18, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6196), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6195), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6205), new DateTime(2025, 2, 18, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6204), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6203), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6212), new DateTime(2025, 2, 18, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6211), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6210), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6219), new DateTime(2025, 2, 18, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6218), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6217), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DueDate", "IssueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6226), new DateTime(2025, 2, 18, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6225), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6224), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6102), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6109), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6114), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6120), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6168), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5913), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5969), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5971), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5973), new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5974) });
        }
    }
}
