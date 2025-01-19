using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04cbec9d-ca49-4f85-b2cd-effb1b8a5f58", null, "", "Admin", "ADMIN" },
                    { "2671d59b-cae5-44bd-967c-4f39c966007a", null, "", "Manager", "MANAGER" },
                    { "bcb68209-0574-4c35-ad67-f117afb0a49d", null, "", "Receptionist", "RECEPTIONIST" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name", "Symbol" },
                values: new object[,]
                {
                    { 1, "", "USD", "$" },
                    { 2, "", "EUR", "€" },
                    { 3, "", "GBP", "£" },
                    { 4, "", "JPY", "¥" },
                    { 5, "", "CZK", "Kč" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedAt", "DateOfBirth", "DateOfExpiry", "DateOfIssue", "DocumentNumber", "Email", "FirstName", "LastName", "Nationality", "PersonalIdentificationNumber", "Phone", "PlaceOfBirth", "PostalCode", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Hlavní 123", "Praha", "Česká republika", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6004), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725912987", "jan.novak@example.com", "Jan", "Novák", "Česká republika", "CZ1234567890", "+420123456789", "Praha", "11000", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6005) },
                    { 2, "Náměstí 456", "Brno", "Česká republika", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6012), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2029, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725912298", "petr.svoboda@example.com", "Petr", "Svoboda", "Česká republika", "CZ0987654321", "+420987654321", "Brno", "60200", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6013) },
                    { 3, "Sokolská 789", "Ostrava", "Česká republika", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6019), new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420745912987", "marie.cerna@example.com", "Marie", "Černá", "Česká republika", "CZ4567891234", "+420654789123", "Ostrava", "70200", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6020) },
                    { 4, "Jasná 321", "Plzeň", "Česká republika", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6026), new DateTime(1988, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2032, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725612987", "anna.havlickova@example.com", "Anna", "Havlíčková", "Česká republika", "CZ3216549870", "+420321654987", "Plzeň", "30100", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6027) },
                    { 5, "Květná 159", "Liberec", "Česká republika", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6033), new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725922987", "tomas.prochazka@example.com", "Tomáš", "Procházka", "Česká republika", "CZ1597534680", "+420159753468", "Liberec", "46000", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6034) },
                    { 6, "Lípa 753", "Ústí nad Labem", "Česká republika", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6040), new DateTime(1998, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725912387", "petra.dvorakova@example.com", "Petra", "Dvořáková", "Česká republika", "CZ7539518520", "+420753951852", "Ústí nad Labem", "40000", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6041) },
                    { 7, "Březová 852", "Hradec Králové", "Česká republika", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6047), new DateTime(1987, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725112987", "jakub.novotny@example.com", "Jakub", "Novotný", "Česká republika", "CZ8524567890", "+420852456789", "Hradec Králové", "50000", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6048) },
                    { 8, "Růžová 258", "Zlín", "Česká republika", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6054), new DateTime(1993, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420025912987", "lucie.krejcova@example.com", "Lucie", "Krejčová", "Česká republika", "CZ2589631470", "+420258963147", "Zlín", "76000", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6055) },
                    { 9, "Modrá 369", "Karlovy Vary", "Česká republika", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6061), new DateTime(1980, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2028, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420723912987", "martin.fiala@example.com", "Martin", "Fiala", "Česká republika", "CZ3692581470", "+420369258147", "Karlovy Vary", "36000", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6062) },
                    { 10, "Violetová 741", "Jihlava", "Česká republika", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6068), new DateTime(1991, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420225912987", "barbora.kovarova@example.com", "Barbora", "Kovářová", "Česká republika", "CZ7418529630", "+420741852963", "Jihlava", "58601", new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6069) }
                });

            migrationBuilder.InsertData(
                table: "InsuranceCompanies",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber", "Website" },
                values: new object[,]
                {
                    { 1, "", "", "Česká pojišťovna", "", "" },
                    { 2, "", "", "Kooperativa", "", "" },
                    { 3, "", "", "Allianz", "", "" }
                });

            migrationBuilder.InsertData(
                table: "MealPlans",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Bez stravy", 0m },
                    { 2, "Snídaně", 0m },
                    { 3, "Polopenze", 0m },
                    { 4, "Plná penze", 0m }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, "", true, "Hotově" },
                    { 2, "", true, "Kartou" },
                    { 3, "", true, "Převodem" }
                });

            migrationBuilder.InsertData(
                table: "ReservationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Potvrzená" },
                    { 2, "Zrušená" },
                    { 3, "Čeká na platbu" }
                });

            migrationBuilder.InsertData(
                table: "RoomStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Volný" },
                    { 2, "Obsazený" },
                    { 3, "Mimo provoz" },
                    { 4, "Čeká na úklid" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Jednolůžkový pokoj" },
                    { 2, "Dvoulůžkový pokoj" },
                    { 3, "Třílůžkový pokoj" },
                    { 4, "Rodinný pokoj" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "MaxAdults", "MaxChildren", "Price", "RoomNumber", "RoomStatusId", "RoomTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5913), "Jednolůžkový pokoj s výhledem na zahradu", "", 1, 0, 2200m, "101", 1, 1, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5961) },
                    { 2, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5969), "Dvoulůžkový pokoj", "", 2, 1, 2700m, "102", 1, 2, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5970) },
                    { 3, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5971), "Třílůžkový pokoj s výhledem na moře", "", 3, 2, 3800m, "103", 1, 3, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5972) },
                    { 4, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5973), "Rodinný pokoj", "", 4, 3, 4500m, "104", 1, 4, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(5974) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "AdminNote", "Adults", "CheckIn", "CheckOut", "Children", "CreatedAt", "CustomerId", "MealPlanId", "ReservationStatusId", "RoomId", "SpecialRequest", "TotalPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Poznámka pro recepci", 1, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6102), 1, 2, 1, 1, "Přistýlka", 6600m, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6103) },
                    { 2, "Poznámka pro recepci", 2, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6109), 2, 3, 1, 2, "Dětská postýlka", 13500m, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6110) },
                    { 3, "Poznámka pro recepci", 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6114), 3, 4, 1, 3, "Bezlepková dieta", 19000m, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6115) },
                    { 4, "Poznámka pro recepci", 4, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6120), 4, 4, 1, 4, "Elktro mobil", 22500m, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6121) },
                    { 5, "Poznámka pro recepci", 1, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6168), 5, 2, 1, 1, "Přistýlka", 6600m, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6168) }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedAt", "CurrencyId", "Description", "Discount", "DueDate", "IsPaid", "IssueDate", "Prepayment", "Price", "ReservationId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6198), 1, "", 0.0m, new DateTime(2025, 2, 18, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6196), false, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6195), 0.0m, 1500.00m, 1, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6199) },
                    { 2, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6205), 1, "", 0.0m, new DateTime(2025, 2, 18, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6204), true, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6203), 0.0m, 2500.00m, 2, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6206) },
                    { 3, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6212), 1, "", 0.0m, new DateTime(2025, 2, 18, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6211), false, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6210), 0.0m, 1200.00m, 3, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6213) },
                    { 4, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6219), 1, "", 0.0m, new DateTime(2025, 2, 18, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6218), true, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6217), 0.0m, 2000.00m, 4, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6220) },
                    { 5, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6226), 1, "", 0.0m, new DateTime(2025, 2, 18, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6225), false, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6224), 0.0m, 1700.00m, 5, new DateTime(2025, 1, 19, 10, 49, 44, 992, DateTimeKind.Local).AddTicks(6227) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "InsuranceCompanies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InsuranceCompanies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InsuranceCompanies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
