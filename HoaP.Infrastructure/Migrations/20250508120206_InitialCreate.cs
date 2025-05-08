using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HoaP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalIdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMainGuest = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPerNight = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalIdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsEmployed = table.Column<bool>(type: "bit", nullable: false),
                    InsuranceCompanyId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_InsuranceCompanies_InsuranceCompanyId",
                        column: x => x.InsuranceCompanyId,
                        principalTable: "InsuranceCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    RoomStatusId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MaxAdults = table.Column<int>(type: "int", nullable: false),
                    MaxChildren = table.Column<int>(type: "int", nullable: false),
                    IsDisable = table.Column<bool>(type: "bit", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomStatuses_RoomStatusId",
                        column: x => x.RoomStatusId,
                        principalTable: "RoomStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Prepayment = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskItems_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ReservationStatusId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Adults = table.Column<int>(type: "int", nullable: false),
                    Children = table.Column<int>(type: "int", nullable: false),
                    MealPlanId = table.Column<int>(type: "int", nullable: false),
                    SpecialRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_MealPlans_MealPlanId",
                        column: x => x.MealPlanId,
                        principalTable: "MealPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationStatuses_ReservationStatusId",
                        column: x => x.ReservationStatusId,
                        principalTable: "ReservationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceReservations_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceReservations_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReservationCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IsMainGuest = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationCustomers", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "ReservationServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    OriginalUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationServices_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1dab78de-fbe8-417d-b5ff-090a1cbd39a4", null, "", "Admin", "ADMIN" },
                    { "3a47ee19-1828-4056-804f-b7be8a238439", null, "", "Manager", "MANAGER" },
                    { "abc013b6-a221-467d-9e4b-b8781fe95b07", null, "", "Receptionist", "RECEPTIONIST" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Name", "Rate", "Symbol" },
                values: new object[,]
                {
                    { 1, "USD", "Americký dolar", 22.50m, "$" },
                    { 2, "EUR", "Euro", 24.80m, "€" },
                    { 3, "CZK", "Česká koruna", 1.00m, "Kč" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedAt", "DateOfBirth", "DateOfExpiry", "DateOfIssue", "DocumentNumber", "Email", "FirstName", "IsMainGuest", "LastName", "Nationality", "PersonalIdentificationNumber", "Phone", "PlaceOfBirth", "PostalCode", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Hlavní 123", "Praha", "Česká republika", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5080), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725912987", "jan.novak@example.com", "Jan", false, "Novák", "Česká republika", "CZ1234567890", "+420123456789", "Praha", "11000", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5081) },
                    { 2, "Náměstí 456", "Brno", "Česká republika", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5087), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2029, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725912298", "petr.svoboda@example.com", "Petr", false, "Svoboda", "Česká republika", "CZ0987654321", "+420987654321", "Brno", "60200", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5088) },
                    { 3, "Sokolská 789", "Ostrava", "Česká republika", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5095), new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420745912987", "marie.cerna@example.com", "Marie", false, "Černá", "Česká republika", "CZ4567891234", "+420654789123", "Ostrava", "70200", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5096) },
                    { 4, "Jasná 321", "Plzeň", "Česká republika", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5103), new DateTime(1988, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2032, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725612987", "anna.havlickova@example.com", "Anna", false, "Havlíčková", "Česká republika", "CZ3216549870", "+420321654987", "Plzeň", "30100", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5104) },
                    { 5, "Květná 159", "Liberec", "Česká republika", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5110), new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725922987", "tomas.prochazka@example.com", "Tomáš", false, "Procházka", "Česká republika", "CZ1597534680", "+420159753468", "Liberec", "46000", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5111) },
                    { 6, "Lípa 753", "Ústí nad Labem", "Česká republika", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5117), new DateTime(1998, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725912387", "petra.dvorakova@example.com", "Petra", false, "Dvořáková", "Česká republika", "CZ7539518520", "+420753951852", "Ústí nad Labem", "40000", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5118) },
                    { 7, "Březová 852", "Hradec Králové", "Česká republika", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5124), new DateTime(1987, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725112987", "jakub.novotny@example.com", "Jakub", false, "Novotný", "Česká republika", "CZ8524567890", "+420852456789", "Hradec Králové", "50000", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5125) },
                    { 8, "Růžová 258", "Zlín", "Česká republika", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5131), new DateTime(1993, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420025912987", "lucie.krejcova@example.com", "Lucie", false, "Krejčová", "Česká republika", "CZ2589631470", "+420258963147", "Zlín", "76000", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5131) },
                    { 9, "Modrá 369", "Karlovy Vary", "Česká republika", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5138), new DateTime(1980, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2028, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420723912987", "martin.fiala@example.com", "Martin", false, "Fiala", "Česká republika", "CZ3692581470", "+420369258147", "Karlovy Vary", "36000", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5138) },
                    { 10, "Violetová 741", "Jihlava", "Česká republika", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5144), new DateTime(1991, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420225912987", "barbora.kovarova@example.com", "Barbora", false, "Kovářová", "Česká republika", "CZ7418529630", "+420741852963", "Jihlava", "58601", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5145) }
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
                    { 2, "Zrušená" }
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
                table: "Services",
                columns: new[] { "Id", "Description", "IsPerNight", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", false, "Wellness vstup", 500m },
                    { 2, "", true, "Parkování", 250m },
                    { 3, "", true, "Domácí mazlíček", 300m },
                    { 4, "", false, "Služba žehlení", 150m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "CurrencyId", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7bea0c33-c854-48f3-a227-c0891b7e630b", 0, "Hlavní 123", "Praha", "6d548c04-393b-4a4e-bbd6-037fae089be3", "Česká republika", null, "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEKoEDwNOYPt2fepo82pKPgxqnUpeZQh0p7N7XZN4gqcCf+sIfshhT9uFv10yDp34ag==", "CZ1234567890", null, false, "Praha", "11000", new byte[] { 137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82, 0, 0, 6, 81, 0, 0, 4, 238, 4, 3, 0, 0, 0, 175, 199, 24, 245, 0, 0, 0, 9, 112, 72, 89, 115, 0, 0, 30, 194, 0, 0, 30, 194, 1, 110, 208, 117, 62, 0, 0, 0, 33, 80, 76, 84, 69, 0, 0, 0, 255, 255, 255, 153, 153, 153, 26, 26, 26, 64, 64, 64, 106, 106, 106, 226, 226, 226, 246, 246, 246, 201, 201, 201, 175, 175, 175, 136, 136, 136, 222, 43, 153, 88, 0, 0, 32, 0, 73, 68, 65, 84, 120, 1, 237, 157, 203, 127, 36, 87, 149, 231, 19, 167, 202, 216, 94, 17, 6, 75, 85, 94, 73, 221, 48, 13, 172, 178, 168, 178, 13, 172, 82, 99, 27, 247, 135, 149, 212, 216, 128, 103, 85, 106, 30, 61, 236, 156, 188, 108, 88, 73, 128, 27, 62, 189, 82, 242, 24, 108, 86, 170, 230, 53, 204, 95, 57, 37, 203, 82, 62, 148, 143, 115, 110, 220, 27, 39, 206, 61, 95, 47, 92, 249, 56, 17, 113, 239, 247, 252, 190, 138, 200, 204, 200, 200, 65, 195, 127, 16, 128, 192, 86, 2, 159, 26, 108, 45, 161, 0, 2, 16, 104, 48, 133, 16, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 144, 1, 8, 72, 8, 96, 138, 132, 18, 53, 16, 192, 20, 50, 0, 1, 9, 1, 76, 145, 80, 162, 6, 2, 152, 66, 6, 32, 32, 33, 128, 41, 18, 74, 212, 64, 0, 83, 200, 0, 4, 36, 4, 48, 69, 66, 137, 26, 8, 96, 10, 25, 128, 128, 132, 0, 166, 72, 40, 81, 3, 1, 76, 33, 3, 16, 144, 16, 192, 20, 9, 37, 106, 32, 128, 41, 100, 0, 2, 18, 2, 152, 34, 161, 68, 13, 4, 48, 133, 12, 64, 64, 66, 0, 83, 36, 148, 168, 129, 0, 166, 244, 41, 3, 239, 253, 230, 183, 95, 252, 235, 91, 111, 62, 249, 239, 173, 183, 254, 223, 23, 62, 248, 207, 73, 159, 6, 23, 124, 44, 152, 210, 147, 0, 252, 239, 63, 253, 245, 213, 209, 96, 249, 191, 135, 175, 255, 247, 111, 208, 165, 23, 45, 194, 148, 30, 180, 97, 239, 23, 127, 25, 47, 59, 50, 187, 63, 124, 253, 31, 103, 61, 24, 100, 244, 33, 96, 138, 117, 2, 118, 255, 235, 205, 209, 76, 139, 53, 183, 30, 190, 253, 107, 235, 113, 70, 223, 62, 166, 216, 38, 224, 103, 127, 121, 176, 70, 142, 133, 135, 71, 131, 193, 235, 159, 183, 29, 105, 244, 173, 99, 138, 101, 2, 254, 253, 27, 131, 225, 130, 17, 27, 239, 236, 188, 61, 177, 28, 108, 240, 109, 99, 138, 93, 0, 126, 241, 234, 70, 49, 86, 60, 57, 124, 251, 196, 110, 184, 193, 183, 140, 41, 86, 1, 120, 178, 63, 73, 248, 111, 231, 31, 19, 171, 1, 7, 223, 46, 166, 216, 4, 224, 238, 155, 9, 154, 124, 180, 200, 206, 223, 108, 70, 28, 125, 171, 152, 98, 145, 128, 189, 207, 165, 122, 114, 185, 220, 75, 103, 22, 99, 142, 190, 77, 76, 49, 72, 192, 15, 213, 47, 80, 22, 197, 26, 126, 219, 96, 208, 209, 55, 137, 41, 157, 39, 96, 247, 247, 138, 247, 187, 22, 21, 185, 185, 199, 110, 165, 243, 182, 97, 74, 215, 200, 127, 118, 116, 147, 247, 22, 55, 216, 173, 116, 221, 55, 76, 233, 152, 248, 251, 163, 22, 126, 204, 47, 250, 245, 147, 142, 71, 30, 124, 115, 152, 210, 105, 0, 118, 255, 121, 62, 236, 237, 110, 239, 252, 177, 211, 161, 71, 223, 24, 166, 116, 153, 128, 247, 198, 237, 228, 88, 92, 122, 248, 205, 46, 199, 30, 125, 91, 152, 210, 97, 2, 126, 56, 90, 140, 122, 235, 123, 255, 218, 225, 224, 163, 111, 10, 83, 186, 75, 192, 247, 114, 139, 50, 24, 124, 105, 210, 221, 240, 131, 111, 9, 83, 58, 11, 192, 251, 173, 119, 33, 43, 86, 240, 213, 147, 206, 198, 31, 124, 67, 152, 210, 85, 0, 126, 191, 34, 231, 25, 30, 186, 115, 214, 213, 4, 130, 111, 7, 83, 58, 10, 64, 198, 55, 189, 22, 253, 218, 65, 149, 78, 90, 136, 41, 157, 96, 222, 43, 38, 202, 96, 240, 16, 85, 186, 232, 33, 166, 116, 65, 185, 164, 40, 131, 1, 123, 149, 46, 122, 136, 41, 29, 80, 222, 251, 221, 226, 1, 83, 238, 123, 168, 210, 65, 19, 49, 165, 3, 200, 133, 94, 204, 207, 132, 187, 115, 210, 193, 44, 130, 111, 2, 83, 202, 7, 224, 87, 179, 72, 151, 186, 133, 42, 197, 219, 136, 41, 197, 17, 127, 183, 148, 30, 243, 235, 253, 234, 164, 248, 60, 130, 111, 0, 83, 74, 7, 224, 39, 243, 129, 46, 119, 251, 43, 165, 231, 17, 125, 253, 152, 82, 56, 1, 207, 151, 147, 99, 113, 205, 156, 3, 86, 182, 147, 152, 82, 150, 239, 189, 241, 98, 158, 11, 222, 227, 204, 226, 162, 173, 196, 148, 162, 120, 119, 143, 10, 170, 177, 180, 234, 225, 65, 209, 169, 68, 95, 57, 166, 20, 77, 64, 193, 143, 230, 151, 60, 121, 114, 151, 143, 85, 74, 246, 18, 83, 74, 210, 237, 228, 109, 175, 153, 50, 119, 74, 206, 37, 250, 186, 49, 165, 96, 2, 126, 62, 11, 113, 55, 183, 120, 3, 172, 92, 55, 49, 165, 28, 219, 187, 163, 110, 252, 152, 219, 10, 175, 234, 139, 181, 19, 83, 138, 161, 221, 187, 152, 139, 112, 71, 55, 135, 211, 98, 211, 137, 190, 98, 76, 41, 150, 128, 95, 118, 100, 199, 194, 102, 238, 76, 138, 205, 39, 248, 138, 49, 165, 84, 0, 58, 127, 145, 114, 101, 12, 47, 85, 10, 53, 20, 83, 10, 129, 221, 29, 47, 252, 173, 239, 238, 206, 113, 161, 9, 69, 95, 45, 166, 20, 74, 192, 121, 119, 110, 44, 110, 233, 193, 73, 161, 25, 5, 95, 45, 166, 148, 9, 64, 71, 231, 69, 46, 74, 114, 117, 239, 169, 50, 51, 138, 190, 86, 76, 41, 146, 0, 131, 55, 136, 103, 210, 124, 171, 200, 148, 162, 175, 20, 83, 138, 36, 160, 211, 179, 88, 102, 142, 92, 221, 26, 158, 20, 153, 83, 240, 149, 98, 74, 137, 0, 24, 30, 123, 93, 202, 194, 241, 87, 129, 166, 98, 74, 1, 168, 187, 163, 171, 63, 238, 102, 255, 231, 248, 43, 127, 87, 49, 37, 63, 211, 166, 240, 165, 88, 182, 11, 184, 115, 82, 96, 86, 193, 87, 137, 41, 249, 3, 240, 226, 246, 40, 151, 174, 248, 114, 254, 89, 69, 95, 35, 166, 100, 79, 192, 222, 184, 180, 7, 130, 245, 31, 100, 159, 86, 244, 21, 98, 74, 246, 4, 116, 252, 165, 148, 213, 218, 240, 85, 149, 220, 125, 197, 148, 220, 68, 77, 63, 74, 153, 105, 243, 70, 238, 121, 69, 95, 31, 166, 228, 78, 192, 249, 44, 173, 150, 183, 248, 80, 37, 115, 99, 49, 37, 51, 208, 30, 188, 156, 255, 72, 208, 33, 47, 234, 243, 118, 22, 83, 242, 242, 108, 142, 44, 119, 36, 243, 219, 30, 78, 51, 207, 44, 248, 234, 48, 37, 111, 0, 140, 63, 157, 159, 87, 133, 79, 234, 179, 182, 22, 83, 178, 226, 236, 197, 59, 196, 215, 186, 60, 206, 58, 181, 232, 43, 195, 148, 172, 9, 248, 209, 117, 74, 251, 240, 47, 239, 20, 231, 236, 45, 166, 228, 164, 105, 126, 194, 215, 162, 160, 199, 57, 231, 22, 125, 93, 152, 146, 51, 1, 223, 89, 76, 170, 245, 61, 46, 63, 145, 177, 185, 152, 146, 17, 102, 79, 62, 116, 156, 9, 202, 199, 143, 249, 186, 139, 41, 249, 88, 54, 191, 156, 101, 180, 31, 183, 118, 38, 25, 103, 23, 124, 85, 152, 146, 47, 0, 189, 219, 165, 12, 6, 236, 84, 178, 181, 23, 83, 178, 161, 236, 223, 46, 229, 201, 229, 239, 39, 249, 166, 23, 124, 77, 152, 146, 45, 0, 61, 220, 165, 176, 83, 201, 214, 221, 6, 83, 178, 177, 236, 221, 171, 148, 203, 215, 74, 236, 84, 114, 245, 23, 83, 114, 145, 236, 229, 46, 101, 48, 56, 204, 53, 191, 232, 235, 193, 148, 92, 9, 232, 217, 103, 41, 215, 111, 190, 241, 65, 125, 166, 6, 99, 74, 38, 144, 61, 251, 120, 254, 90, 148, 193, 128, 235, 180, 228, 233, 48, 166, 228, 225, 216, 244, 226, 59, 193, 51, 63, 102, 183, 216, 169, 228, 233, 48, 166, 228, 225, 216, 171, 147, 136, 103, 154, 92, 222, 122, 156, 103, 134, 209, 215, 130, 41, 121, 18, 240, 227, 197, 116, 246, 233, 30, 223, 83, 201, 210, 98, 76, 201, 130, 177, 63, 95, 117, 188, 237, 232, 112, 154, 103, 138, 193, 215, 130, 41, 89, 2, 240, 194, 237, 128, 246, 231, 17, 190, 81, 159, 163, 199, 152, 146, 131, 98, 179, 223, 31, 47, 110, 143, 132, 203, 180, 228, 232, 49, 166, 228, 160, 120, 247, 118, 60, 251, 244, 8, 231, 73, 102, 104, 50, 166, 100, 128, 216, 244, 244, 83, 199, 107, 91, 119, 114, 204, 49, 250, 58, 48, 37, 67, 2, 246, 70, 215, 153, 236, 233, 191, 199, 25, 38, 25, 125, 21, 152, 146, 33, 1, 159, 233, 169, 32, 55, 195, 122, 54, 195, 36, 163, 175, 2, 83, 50, 36, 224, 232, 38, 146, 125, 189, 113, 150, 97, 150, 193, 87, 129, 41, 237, 3, 112, 175, 175, 126, 204, 198, 245, 114, 251, 89, 70, 95, 3, 166, 180, 79, 192, 233, 44, 145, 125, 189, 197, 215, 84, 90, 183, 25, 83, 90, 35, 236, 253, 235, 249, 75, 125, 143, 91, 79, 51, 250, 10, 48, 165, 117, 2, 122, 255, 122, 254, 210, 20, 78, 254, 106, 219, 103, 76, 105, 75, 176, 249, 243, 101, 18, 123, 255, 223, 73, 235, 121, 6, 95, 1, 166, 180, 13, 64, 207, 63, 159, 191, 86, 248, 149, 182, 243, 140, 190, 60, 166, 180, 77, 64, 207, 63, 159, 191, 54, 133, 47, 116, 181, 108, 52, 166, 180, 4, 216, 140, 175, 179, 216, 243, 127, 15, 218, 78, 52, 248, 242, 152, 210, 50, 0, 125, 249, 181, 186, 173, 158, 62, 221, 114, 162, 209, 23, 199, 148, 150, 9, 56, 221, 26, 209, 158, 20, 240, 145, 74, 187, 78, 99, 74, 59, 126, 123, 15, 122, 34, 194, 246, 97, 28, 183, 155, 105, 244, 165, 49, 165, 93, 2, 122, 253, 101, 199, 69, 123, 158, 105, 55, 211, 232, 75, 99, 74, 187, 4, 156, 47, 166, 177, 207, 247, 134, 147, 118, 83, 13, 190, 52, 166, 180, 10, 128, 139, 51, 89, 174, 245, 61, 110, 53, 213, 232, 11, 99, 74, 171, 4, 184, 56, 147, 229, 218, 20, 190, 165, 210, 166, 215, 152, 210, 134, 94, 115, 126, 157, 66, 15, 255, 114, 248, 213, 166, 215, 152, 210, 134, 158, 171, 131, 47, 46, 81, 220, 166, 213, 252, 126, 74, 43, 122, 63, 241, 176, 43, 153, 141, 145, 195, 175, 22, 221, 102, 159, 210, 2, 158, 175, 131, 175, 193, 128, 195, 175, 22, 205, 198, 148, 22, 240, 154, 209, 236, 239, 181, 139, 91, 199, 109, 38, 27, 124, 89, 76, 105, 17, 0, 55, 231, 124, 93, 107, 204, 135, 143, 233, 221, 198, 148, 116, 118, 205, 233, 117, 2, 189, 252, 203, 37, 242, 210, 187, 141, 41, 233, 236, 154, 177, 23, 67, 110, 198, 121, 208, 98, 182, 193, 23, 197, 148, 244, 0, 60, 127, 19, 64, 55, 55, 56, 245, 62, 185, 221, 152, 146, 140, 174, 249, 145, 27, 65, 110, 6, 202, 55, 31, 147, 219, 141, 41, 201, 232, 250, 252, 235, 66, 55, 106, 44, 223, 56, 75, 159, 110, 240, 37, 49, 37, 57, 0, 187, 203, 41, 244, 112, 159, 31, 136, 72, 237, 55, 166, 164, 146, 107, 92, 157, 29, 121, 109, 49, 215, 253, 74, 237, 55, 166, 164, 146, 243, 246, 1, 253, 149, 43, 124, 76, 159, 218, 111, 76, 73, 37, 215, 227, 223, 213, 190, 222, 129, 172, 250, 247, 113, 234, 124, 163, 47, 135, 41, 169, 9, 112, 248, 30, 241, 165, 57, 188, 79, 156, 216, 112, 76, 73, 4, 231, 241, 61, 226, 75, 83, 120, 159, 56, 177, 225, 152, 146, 8, 174, 185, 184, 204, 157, 195, 255, 78, 82, 39, 28, 124, 57, 76, 73, 12, 128, 179, 47, 113, 205, 148, 62, 76, 156, 112, 244, 197, 48, 37, 49, 1, 142, 46, 95, 52, 179, 228, 242, 22, 231, 19, 167, 117, 28, 83, 210, 184, 245, 253, 135, 181, 23, 237, 152, 191, 199, 249, 196, 105, 29, 199, 148, 52, 110, 46, 79, 101, 185, 18, 230, 44, 113, 198, 193, 23, 195, 148, 180, 0, 236, 142, 230, 255, 78, 187, 186, 125, 152, 54, 227, 232, 75, 97, 74, 90, 2, 220, 125, 221, 113, 38, 51, 47, 84, 146, 90, 142, 41, 73, 216, 154, 71, 179, 228, 121, 187, 245, 48, 109, 198, 209, 151, 194, 148, 180, 4, 92, 120, 243, 99, 110, 188, 103, 105, 83, 14, 190, 20, 166, 36, 5, 192, 229, 25, 247, 31, 203, 50, 60, 76, 154, 114, 244, 133, 48, 37, 41, 1, 142, 95, 166, 112, 234, 87, 82, 199, 185, 134, 100, 26, 54, 135, 95, 12, 158, 29, 126, 113, 234, 87, 74, 211, 217, 167, 164, 80, 115, 123, 210, 215, 149, 46, 39, 73, 115, 14, 190, 16, 166, 36, 5, 96, 52, 251, 11, 237, 240, 214, 227, 164, 57, 7, 95, 8, 83, 82, 2, 112, 207, 183, 41, 159, 76, 153, 115, 244, 101, 48, 37, 37, 1, 46, 191, 66, 63, 219, 249, 241, 101, 250, 132, 166, 99, 74, 2, 52, 127, 151, 89, 157, 89, 114, 121, 139, 147, 36, 19, 154, 142, 41, 9, 208, 28, 159, 30, 121, 165, 204, 52, 101, 210, 193, 151, 193, 148, 132, 0, 56, 62, 61, 242, 202, 148, 195, 132, 73, 71, 95, 4, 83, 18, 18, 224, 250, 115, 199, 75, 87, 94, 78, 152, 116, 244, 69, 48, 37, 33, 1, 159, 190, 250, 203, 236, 247, 255, 207, 37, 76, 58, 250, 34, 152, 146, 144, 128, 83, 191, 142, 92, 141, 124, 152, 48, 233, 232, 139, 96, 74, 66, 2, 142, 188, 155, 50, 152, 38, 204, 58, 248, 34, 152, 162, 15, 128, 231, 19, 137, 63, 118, 252, 80, 63, 235, 232, 75, 96, 138, 62, 1, 78, 175, 30, 57, 191, 35, 228, 74, 146, 234, 182, 99, 138, 26, 153, 207, 139, 220, 207, 123, 50, 24, 240, 41, 189, 186, 237, 152, 162, 70, 230, 253, 19, 250, 75, 103, 120, 73, 175, 110, 59, 166, 168, 145, 185, 255, 132, 254, 210, 148, 51, 253, 180, 131, 47, 129, 41, 250, 0, 140, 46, 255, 42, 59, 255, 239, 88, 63, 237, 224, 75, 96, 138, 58, 0, 119, 157, 75, 242, 209, 240, 239, 171, 167, 29, 125, 1, 76, 81, 39, 192, 237, 21, 137, 231, 13, 127, 86, 61, 237, 232, 11, 96, 138, 58, 1, 238, 207, 101, 185, 52, 134, 239, 210, 107, 251, 142, 41, 90, 98, 62, 127, 223, 113, 126, 127, 242, 209, 109, 245, 180, 163, 47, 128, 41, 234, 4, 28, 221, 74, 157, 199, 7, 166, 234, 121, 7, 95, 0, 83, 212, 1, 24, 121, 20, 227, 214, 152, 143, 213, 243, 14, 190, 0, 166, 104, 3, 112, 239, 86, 232, 92, 62, 112, 95, 59, 239, 232, 245, 152, 162, 77, 64, 21, 111, 125, 241, 211, 92, 218, 182, 115, 13, 73, 53, 177, 42, 222, 250, 226, 205, 47, 117, 223, 217, 167, 104, 145, 157, 186, 60, 216, 186, 53, 104, 206, 252, 82, 54, 30, 83, 148, 192, 156, 95, 104, 117, 102, 204, 137, 118, 226, 193, 235, 49, 69, 27, 128, 241, 44, 108, 174, 111, 29, 104, 39, 30, 188, 30, 83, 148, 1, 216, 115, 173, 199, 220, 224, 15, 149, 19, 143, 94, 142, 41, 202, 4, 84, 242, 38, 241, 96, 240, 138, 114, 226, 209, 203, 49, 69, 153, 128, 159, 204, 253, 89, 118, 125, 147, 31, 70, 213, 117, 30, 83, 116, 188, 154, 74, 222, 36, 230, 109, 98, 101, 223, 249, 60, 69, 11, 236, 145, 235, 29, 201, 220, 224, 121, 155, 88, 215, 122, 246, 41, 58, 94, 205, 254, 92, 216, 124, 223, 156, 40, 103, 30, 188, 28, 83, 148, 1, 24, 251, 214, 99, 110, 244, 83, 229, 204, 131, 151, 99, 138, 50, 0, 163, 185, 172, 249, 190, 121, 172, 156, 121, 240, 114, 76, 209, 5, 160, 138, 47, 209, 95, 25, 126, 95, 55, 243, 232, 213, 152, 162, 75, 64, 5, 215, 143, 188, 222, 19, 242, 107, 143, 170, 214, 99, 138, 10, 87, 83, 205, 199, 41, 131, 1, 23, 157, 80, 181, 30, 83, 84, 184, 234, 249, 56, 101, 48, 224, 71, 84, 84, 173, 199, 20, 21, 174, 230, 209, 245, 177, 139, 255, 127, 249, 93, 84, 85, 235, 49, 69, 133, 171, 146, 11, 179, 92, 105, 62, 209, 77, 61, 120, 53, 166, 232, 2, 112, 225, 127, 95, 114, 51, 131, 19, 221, 212, 131, 87, 99, 138, 46, 0, 227, 155, 156, 249, 191, 113, 160, 155, 122, 240, 106, 76, 209, 5, 192, 191, 31, 179, 25, 28, 235, 166, 30, 188, 26, 83, 84, 1, 168, 224, 135, 235, 102, 166, 28, 170, 166, 30, 189, 24, 83, 84, 9, 168, 230, 123, 92, 151, 190, 240, 209, 163, 166, 247, 152, 162, 161, 213, 188, 56, 251, 139, 236, 255, 22, 223, 229, 210, 244, 30, 83, 52, 180, 106, 248, 137, 199, 153, 225, 252, 216, 163, 166, 247, 152, 162, 161, 85, 211, 71, 244, 124, 235, 81, 213, 121, 190, 243, 168, 195, 245, 206, 236, 47, 178, 255, 91, 15, 117, 115, 15, 94, 205, 62, 69, 21, 128, 83, 255, 126, 204, 102, 192, 247, 131, 53, 189, 199, 20, 13, 173, 138, 190, 27, 124, 41, 204, 68, 53, 247, 224, 197, 152, 162, 10, 192, 209, 236, 47, 114, 5, 183, 206, 84, 115, 15, 94, 140, 41, 170, 0, 140, 43, 240, 99, 54, 133, 169, 106, 238, 193, 139, 49, 69, 21, 128, 186, 76, 121, 172, 154, 123, 240, 98, 76, 81, 5, 96, 246, 247, 184, 134, 91, 199, 170, 185, 7, 47, 198, 20, 77, 0, 170, 58, 237, 107, 48, 56, 212, 204, 61, 122, 45, 166, 104, 18, 80, 209, 149, 89, 46, 247, 137, 247, 53, 115, 143, 94, 139, 41, 154, 4, 84, 116, 101, 150, 75, 83, 56, 69, 82, 209, 124, 76, 81, 192, 170, 235, 4, 201, 193, 224, 105, 205, 220, 163, 215, 98, 138, 38, 1, 149, 252, 110, 240, 229, 254, 228, 242, 63, 174, 99, 164, 104, 62, 166, 40, 96, 213, 117, 42, 241, 96, 192, 201, 196, 138, 230, 99, 138, 2, 86, 93, 167, 18, 115, 197, 47, 77, 235, 57, 151, 88, 69, 171, 154, 159, 25, 186, 58, 250, 186, 163, 154, 124, 240, 98, 246, 41, 154, 0, 188, 115, 149, 176, 90, 254, 207, 181, 241, 20, 205, 199, 20, 5, 172, 154, 174, 32, 121, 105, 59, 166, 40, 154, 143, 41, 10, 88, 205, 105, 45, 123, 147, 143, 231, 161, 153, 123, 244, 90, 76, 209, 36, 224, 28, 83, 52, 184, 170, 170, 197, 20, 77, 59, 107, 51, 229, 68, 51, 249, 224, 181, 152, 162, 9, 192, 69, 101, 251, 20, 76, 145, 119, 31, 83, 228, 172, 154, 230, 168, 50, 83, 206, 52, 147, 15, 94, 139, 41, 154, 0, 96, 138, 134, 86, 93, 181, 152, 162, 233, 103, 109, 166, 76, 53, 147, 15, 94, 139, 41, 154, 0, 140, 43, 59, 250, 58, 208, 76, 62, 120, 45, 166, 104, 2, 128, 41, 26, 90, 117, 213, 98, 138, 166, 159, 163, 202, 246, 41, 143, 53, 147, 15, 94, 139, 41, 154, 0, 212, 182, 79, 193, 20, 121, 247, 49, 69, 206, 170, 105, 106, 219, 167, 28, 107, 38, 31, 188, 22, 83, 52, 1, 168, 236, 224, 107, 112, 172, 153, 124, 240, 90, 76, 209, 4, 128, 125, 138, 134, 86, 93, 181, 152, 162, 233, 39, 251, 20, 13, 173, 186, 106, 49, 69, 211, 79, 76, 209, 208, 170, 171, 22, 83, 52, 253, 172, 205, 148, 67, 205, 228, 131, 215, 98, 138, 38, 0, 181, 153, 114, 172, 153, 124, 240, 90, 76, 209, 4, 160, 54, 83, 14, 53, 147, 15, 94, 139, 41, 154, 0, 212, 102, 202, 177, 102, 242, 193, 107, 49, 69, 19, 128, 218, 76, 249, 150, 102, 242, 193, 107, 49, 69, 19, 128, 218, 76, 57, 212, 76, 62, 120, 45, 166, 104, 2, 80, 155, 41, 199, 154, 201, 7, 175, 197, 20, 77, 0, 48, 69, 67, 171, 174, 90, 76, 209, 244, 115, 84, 153, 42, 199, 154, 201, 7, 175, 197, 20, 77, 0, 48, 69, 67, 171, 174, 90, 76, 209, 244, 179, 54, 83, 30, 107, 38, 31, 188, 22, 83, 52, 1, 192, 20, 13, 173, 186, 106, 49, 69, 211, 207, 241, 160, 174, 255, 14, 52, 147, 15, 94, 139, 41, 154, 0, 96, 138, 134, 86, 93, 181, 152, 162, 233, 231, 171, 117, 237, 82, 6, 83, 205, 228, 131, 215, 98, 138, 38, 0, 71, 152, 162, 193, 85, 85, 45, 166, 104, 218, 89, 155, 41, 103, 154, 201, 7, 175, 197, 20, 77, 0, 46, 42, 219, 167, 156, 104, 38, 31, 188, 22, 83, 52, 1, 216, 199, 20, 13, 174, 170, 106, 49, 69, 211, 206, 243, 202, 76, 153, 104, 38, 31, 188, 22, 83, 52, 1, 56, 173, 203, 148, 161, 102, 238, 209, 107, 49, 69, 147, 128, 71, 152, 162, 193, 85, 85, 45, 166, 104, 218, 249, 78, 93, 166, 240, 43, 219, 138, 230, 99, 138, 2, 86, 243, 169, 186, 76, 185, 163, 153, 123, 244, 90, 76, 209, 36, 224, 211, 152, 162, 193, 85, 85, 45, 166, 104, 218, 249, 153, 186, 76, 121, 74, 51, 247, 232, 181, 152, 162, 73, 192, 11, 117, 153, 242, 172, 102, 238, 209, 107, 49, 69, 147, 128, 202, 76, 121, 70, 51, 247, 232, 181, 152, 162, 73, 192, 243, 117, 237, 83, 62, 169, 153, 123, 244, 90, 76, 209, 36, 224, 94, 93, 166, 124, 66, 51, 247, 232, 181, 152, 162, 73, 192, 110, 93, 166, 28, 106, 230, 30, 189, 22, 83, 52, 9, 216, 195, 20, 13, 174, 170, 106, 49, 69, 213, 206, 81, 85, 170, 60, 86, 205, 61, 120, 49, 166, 168, 2, 48, 174, 202, 148, 3, 213, 220, 131, 23, 99, 138, 42, 0, 71, 85, 153, 114, 166, 154, 123, 240, 98, 76, 81, 5, 96, 191, 42, 83, 78, 84, 115, 15, 94, 140, 41, 170, 0, 156, 87, 101, 138, 106, 234, 209, 139, 49, 69, 149, 128, 71, 53, 153, 194, 73, 247, 154, 222, 99, 138, 134, 86, 83, 213, 201, 196, 156, 116, 175, 233, 61, 166, 104, 104, 53, 85, 157, 76, 252, 156, 106, 234, 209, 139, 49, 69, 149, 128, 170, 78, 145, 228, 4, 73, 77, 239, 49, 69, 67, 171, 169, 234, 20, 201, 167, 85, 83, 143, 94, 140, 41, 170, 4, 220, 173, 233, 21, 253, 125, 213, 212, 163, 23, 99, 138, 46, 1, 53, 153, 114, 172, 155, 122, 240, 106, 76, 209, 5, 96, 92, 145, 42, 143, 117, 83, 15, 94, 141, 41, 170, 0, 236, 29, 85, 100, 202, 153, 106, 234, 209, 139, 49, 69, 151, 128, 253, 138, 76, 153, 232, 166, 30, 188, 26, 83, 116, 1, 120, 84, 143, 41, 92, 107, 85, 213, 122, 76, 81, 225, 170, 233, 218, 120, 124, 68, 175, 106, 61, 166, 168, 112, 213, 244, 33, 61, 87, 251, 82, 181, 30, 83, 84, 184, 154, 23, 235, 57, 250, 226, 131, 71, 85, 235, 49, 69, 133, 171, 169, 232, 234, 44, 247, 117, 51, 143, 94, 141, 41, 186, 4, 84, 116, 205, 137, 67, 221, 204, 163, 87, 99, 138, 50, 1, 227, 106, 14, 191, 14, 148, 51, 15, 94, 142, 41, 202, 0, 92, 84, 99, 202, 137, 114, 230, 193, 203, 49, 69, 25, 128, 211, 90, 76, 225, 227, 20, 93, 231, 49, 69, 199, 171, 158, 15, 84, 238, 76, 148, 51, 15, 94, 142, 41, 202, 0, 84, 243, 173, 71, 62, 78, 209, 117, 30, 83, 116, 188, 234, 249, 46, 23, 23, 186, 215, 117, 30, 83, 116, 188, 154, 106, 46, 226, 125, 168, 156, 120, 244, 114, 76, 81, 38, 96, 111, 84, 201, 75, 250, 99, 229, 196, 163, 151, 99, 138, 54, 1, 71, 149, 152, 114, 166, 157, 120, 240, 122, 76, 209, 6, 224, 188, 14, 83, 120, 147, 88, 217, 120, 76, 81, 2, 171, 229, 109, 98, 206, 185, 87, 54, 30, 83, 148, 192, 154, 207, 140, 170, 216, 169, 240, 38, 177, 178, 241, 152, 162, 4, 86, 203, 219, 196, 188, 73, 172, 108, 60, 166, 40, 129, 53, 149, 156, 77, 124, 168, 157, 119, 244, 122, 76, 81, 39, 96, 92, 197, 209, 215, 84, 61, 239, 224, 11, 96, 138, 58, 0, 251, 85, 152, 114, 162, 158, 119, 240, 5, 48, 69, 29, 128, 119, 106, 48, 133, 223, 78, 209, 246, 29, 83, 180, 196, 234, 120, 243, 139, 183, 190, 180, 125, 199, 20, 45, 177, 58, 190, 74, 207, 91, 95, 218, 190, 99, 138, 150, 88, 29, 111, 126, 29, 170, 167, 29, 125, 1, 76, 81, 39, 160, 138, 107, 19, 79, 213, 211, 142, 190, 0, 166, 232, 19, 112, 238, 255, 37, 61, 103, 125, 169, 219, 142, 41, 106, 100, 205, 143, 252, 155, 194, 89, 95, 234, 182, 99, 138, 26, 89, 83, 193, 143, 61, 242, 19, 143, 234, 182, 99, 138, 26, 89, 13, 95, 123, 188, 175, 159, 117, 244, 37, 48, 37, 33, 1, 99, 247, 135, 95, 7, 9, 179, 14, 190, 8, 166, 36, 4, 96, 223, 189, 41, 147, 132, 89, 7, 95, 4, 83, 18, 2, 240, 142, 119, 83, 184, 214, 151, 190, 235, 152, 162, 103, 230, 255, 37, 61, 47, 232, 245, 93, 199, 20, 61, 179, 198, 253, 175, 210, 223, 79, 152, 116, 244, 69, 48, 37, 37, 1, 99, 231, 135, 95, 7, 41, 147, 14, 190, 12, 166, 164, 4, 224, 220, 183, 41, 195, 73, 202, 164, 131, 47, 131, 41, 41, 1, 248, 180, 111, 83, 248, 132, 62, 161, 233, 152, 146, 0, 205, 251, 85, 39, 248, 133, 199, 132, 166, 99, 74, 2, 52, 239, 39, 222, 31, 167, 204, 57, 250, 50, 152, 146, 148, 128, 35, 215, 135, 95, 191, 78, 154, 115, 240, 133, 48, 37, 41, 0, 143, 60, 155, 194, 119, 232, 83, 122, 142, 41, 41, 212, 124, 127, 151, 254, 217, 164, 41, 71, 95, 8, 83, 146, 18, 224, 250, 179, 199, 251, 73, 83, 142, 190, 16, 166, 164, 37, 96, 236, 248, 240, 107, 154, 54, 229, 224, 75, 97, 74, 90, 0, 78, 253, 154, 194, 231, 142, 73, 45, 199, 148, 36, 108, 141, 227, 31, 70, 229, 101, 74, 82, 203, 49, 37, 9, 155, 231, 147, 36, 95, 73, 155, 113, 244, 165, 48, 37, 49, 1, 126, 95, 168, 28, 36, 206, 56, 248, 98, 152, 146, 24, 0, 183, 47, 84, 184, 128, 81, 90, 199, 49, 37, 141, 155, 223, 79, 84, 184, 34, 113, 90, 199, 49, 37, 141, 155, 223, 23, 42, 247, 19, 39, 28, 125, 49, 76, 73, 77, 192, 145, 211, 247, 137, 167, 169, 19, 14, 190, 28, 166, 164, 6, 224, 145, 79, 83, 56, 233, 43, 177, 225, 152, 146, 8, 206, 235, 101, 39, 184, 216, 68, 98, 195, 49, 37, 17, 92, 179, 59, 114, 185, 83, 57, 76, 157, 111, 244, 229, 48, 37, 57, 1, 23, 46, 77, 57, 73, 158, 111, 240, 5, 49, 37, 57, 0, 46, 47, 121, 207, 87, 232, 83, 251, 141, 41, 169, 228, 124, 254, 138, 221, 203, 201, 211, 141, 190, 32, 166, 164, 39, 96, 236, 240, 240, 235, 32, 125, 186, 193, 151, 196, 148, 244, 0, 156, 250, 51, 101, 103, 146, 62, 221, 224, 75, 98, 74, 122, 0, 28, 254, 226, 16, 239, 17, 39, 183, 27, 83, 146, 209, 53, 123, 35, 119, 59, 149, 111, 165, 207, 54, 250, 146, 152, 210, 34, 1, 251, 222, 76, 25, 158, 180, 152, 109, 240, 69, 49, 165, 69, 0, 220, 125, 241, 145, 243, 136, 211, 187, 141, 41, 233, 236, 252, 253, 224, 227, 97, 139, 201, 70, 95, 20, 83, 218, 36, 224, 194, 217, 225, 215, 127, 180, 153, 108, 240, 101, 49, 165, 77, 0, 156, 125, 76, 255, 92, 155, 185, 70, 95, 22, 83, 218, 36, 192, 217, 5, 242, 184, 214, 68, 139, 102, 99, 74, 11, 120, 77, 227, 235, 240, 235, 172, 213, 92, 131, 47, 140, 41, 173, 2, 224, 234, 240, 139, 131, 175, 54, 189, 198, 148, 54, 244, 124, 125, 155, 158, 131, 175, 54, 189, 198, 148, 54, 244, 154, 230, 200, 209, 187, 95, 39, 237, 166, 26, 124, 105, 76, 105, 23, 128, 31, 251, 49, 133, 131, 175, 86, 173, 198, 148, 86, 248, 60, 125, 248, 248, 70, 187, 153, 70, 95, 26, 83, 90, 38, 96, 223, 205, 78, 229, 164, 229, 76, 131, 47, 142, 41, 45, 3, 224, 230, 220, 47, 46, 113, 223, 174, 211, 152, 210, 142, 159, 159, 83, 239, 143, 91, 78, 52, 250, 226, 152, 210, 54, 1, 167, 62, 14, 191, 134, 239, 182, 157, 104, 240, 229, 49, 165, 109, 0, 94, 244, 97, 202, 211, 109, 231, 25, 125, 121, 76, 105, 157, 128, 177, 11, 85, 254, 216, 122, 158, 193, 87, 128, 41, 173, 3, 224, 226, 140, 22, 174, 243, 213, 182, 207, 152, 210, 150, 160, 143, 51, 90, 94, 153, 180, 158, 103, 240, 21, 96, 74, 251, 0, 236, 247, 255, 240, 139, 47, 208, 183, 110, 51, 166, 180, 70, 232, 225, 170, 247, 124, 152, 210, 186, 205, 152, 210, 26, 97, 179, 215, 255, 215, 244, 143, 219, 207, 50, 250, 26, 48, 37, 67, 2, 190, 211, 247, 195, 175, 59, 147, 12, 179, 12, 190, 10, 76, 201, 16, 128, 222, 127, 73, 152, 111, 166, 180, 239, 50, 166, 180, 103, 216, 52, 231, 253, 222, 169, 240, 122, 62, 67, 147, 49, 37, 3, 196, 166, 231, 159, 211, 243, 249, 124, 134, 38, 99, 74, 6, 136, 125, 255, 234, 227, 52, 203, 28, 131, 175, 4, 83, 178, 4, 224, 187, 125, 62, 252, 226, 26, 171, 57, 122, 140, 41, 57, 40, 246, 251, 231, 81, 143, 179, 76, 49, 250, 74, 48, 37, 79, 2, 122, 252, 70, 49, 167, 124, 101, 105, 49, 166, 100, 193, 216, 220, 29, 245, 246, 248, 139, 239, 207, 103, 105, 49, 166, 100, 193, 216, 52, 167, 125, 53, 101, 56, 201, 52, 195, 224, 171, 193, 148, 76, 1, 184, 215, 87, 83, 190, 150, 105, 130, 209, 87, 131, 41, 185, 18, 112, 222, 79, 85, 248, 212, 49, 83, 131, 49, 37, 19, 200, 190, 126, 250, 200, 15, 208, 103, 106, 48, 166, 100, 2, 217, 52, 251, 125, 220, 169, 12, 207, 178, 205, 47, 248, 138, 48, 37, 91, 0, 122, 121, 74, 203, 151, 179, 77, 47, 250, 138, 48, 37, 95, 2, 46, 250, 183, 83, 97, 151, 146, 173, 189, 152, 146, 13, 101, 243, 124, 255, 76, 97, 151, 146, 173, 189, 152, 146, 13, 101, 15, 127, 161, 139, 93, 74, 190, 238, 98, 74, 62, 150, 253, 123, 251, 139, 93, 74, 190, 238, 98, 74, 62, 150, 189, 123, 251, 139, 93, 74, 198, 230, 98, 74, 70, 152, 77, 207, 62, 168, 231, 179, 148, 140, 205, 197, 148, 140, 48, 123, 118, 246, 23, 103, 124, 229, 236, 45, 166, 228, 164, 217, 175, 235, 73, 114, 18, 113, 206, 222, 98, 74, 78, 154, 205, 94, 143, 190, 167, 178, 51, 201, 58, 181, 232, 43, 195, 148, 188, 9, 216, 29, 245, 230, 67, 149, 227, 188, 51, 139, 190, 54, 76, 201, 156, 128, 222, 252, 152, 48, 63, 21, 156, 183, 179, 152, 146, 151, 103, 179, 119, 212, 147, 157, 202, 52, 243, 196, 162, 175, 14, 83, 114, 39, 224, 231, 253, 48, 229, 153, 220, 243, 138, 190, 62, 76, 201, 158, 128, 243, 62, 168, 194, 23, 184, 114, 247, 21, 83, 114, 19, 109, 222, 27, 245, 64, 21, 222, 33, 206, 221, 87, 76, 201, 77, 180, 105, 122, 112, 153, 60, 174, 92, 148, 189, 173, 152, 146, 29, 105, 31, 94, 212, 79, 243, 207, 42, 250, 26, 49, 165, 64, 2, 204, 191, 168, 194, 9, 95, 249, 187, 138, 41, 249, 153, 54, 205, 47, 109, 95, 169, 236, 156, 148, 152, 84, 240, 117, 98, 74, 137, 0, 236, 142, 77, 85, 57, 40, 49, 167, 232, 235, 196, 148, 34, 9, 48, 189, 250, 4, 223, 223, 42, 209, 83, 76, 41, 65, 213, 244, 248, 107, 231, 221, 50, 83, 10, 190, 86, 76, 41, 19, 128, 119, 237, 142, 191, 30, 151, 153, 81, 244, 181, 98, 74, 161, 4, 152, 189, 255, 197, 251, 94, 101, 58, 138, 41, 101, 184, 54, 205, 175, 108, 94, 212, 243, 131, 218, 133, 26, 138, 41, 133, 192, 54, 123, 23, 22, 170, 12, 167, 165, 230, 19, 125, 189, 152, 82, 44, 1, 38, 63, 62, 244, 173, 98, 211, 137, 190, 98, 76, 41, 151, 128, 23, 186, 223, 169, 124, 101, 82, 110, 58, 193, 215, 140, 41, 5, 3, 208, 249, 75, 21, 94, 164, 148, 235, 38, 166, 148, 99, 219, 249, 75, 149, 225, 175, 11, 78, 38, 250, 170, 49, 165, 100, 2, 58, 62, 171, 229, 239, 37, 231, 18, 125, 221, 152, 82, 52, 1, 247, 70, 29, 190, 86, 249, 218, 164, 232, 92, 130, 175, 28, 83, 138, 6, 96, 239, 39, 221, 153, 242, 165, 162, 51, 9, 191, 114, 76, 41, 28, 129, 206, 94, 213, 243, 53, 199, 178, 157, 196, 148, 178, 124, 155, 230, 119, 221, 236, 85, 248, 78, 74, 225, 70, 98, 74, 97, 192, 205, 222, 159, 187, 80, 101, 231, 172, 244, 60, 162, 175, 31, 83, 138, 39, 96, 247, 168, 188, 42, 195, 127, 41, 62, 141, 232, 27, 192, 148, 242, 9, 40, 175, 10, 162, 148, 239, 34, 166, 148, 103, 220, 252, 116, 92, 120, 175, 194, 217, 94, 229, 187, 136, 41, 229, 25, 55, 205, 221, 178, 170, 124, 179, 139, 57, 68, 223, 6, 166, 116, 146, 128, 146, 170, 12, 17, 165, 139, 30, 98, 74, 23, 148, 139, 238, 85, 254, 214, 205, 12, 162, 111, 5, 83, 58, 74, 192, 221, 163, 50, 175, 85, 134, 136, 210, 77, 7, 49, 165, 27, 206, 77, 179, 251, 141, 18, 170, 240, 174, 87, 87, 253, 195, 148, 174, 72, 23, 249, 8, 114, 103, 218, 217, 240, 163, 111, 8, 83, 58, 76, 192, 239, 115, 239, 85, 238, 156, 116, 56, 250, 224, 155, 194, 148, 46, 3, 240, 126, 94, 85, 190, 58, 233, 114, 240, 193, 183, 133, 41, 157, 6, 224, 135, 227, 140, 174, 188, 221, 233, 208, 163, 111, 12, 83, 186, 77, 192, 221, 108, 175, 235, 119, 254, 71, 183, 35, 143, 190, 53, 76, 233, 58, 1, 127, 200, 179, 87, 249, 234, 89, 215, 3, 15, 190, 61, 76, 233, 58, 0, 123, 63, 203, 112, 4, 54, 252, 118, 215, 195, 14, 191, 61, 76, 233, 62, 2, 123, 159, 29, 181, 220, 175, 188, 196, 69, 88, 58, 111, 27, 166, 116, 142, 252, 201, 6, 219, 237, 86, 216, 161, 88, 244, 12, 83, 44, 168, 55, 205, 31, 210, 119, 43, 95, 63, 179, 25, 114, 240, 173, 98, 138, 81, 0, 118, 63, 155, 118, 4, 246, 210, 255, 49, 26, 112, 244, 205, 98, 138, 89, 2, 238, 254, 69, 239, 202, 67, 222, 26, 182, 234, 23, 166, 88, 145, 111, 154, 189, 247, 148, 174, 188, 244, 121, 187, 193, 134, 223, 50, 166, 152, 70, 96, 247, 115, 99, 233, 142, 101, 248, 58, 199, 93, 150, 189, 194, 20, 75, 250, 79, 182, 253, 238, 47, 222, 28, 9, 100, 121, 248, 223, 39, 198, 3, 141, 190, 121, 76, 177, 79, 192, 79, 183, 201, 242, 218, 63, 248, 252, 196, 188, 77, 152, 98, 222, 130, 203, 1, 236, 253, 224, 115, 171, 119, 45, 195, 215, 254, 215, 231, 79, 122, 49, 196, 232, 131, 192, 148, 254, 36, 224, 167, 31, 126, 241, 173, 55, 95, 123, 240, 96, 56, 24, 140, 30, 60, 120, 237, 181, 183, 254, 237, 11, 255, 57, 153, 244, 103, 124, 177, 71, 130, 41, 125, 237, 63, 138, 244, 171, 51, 152, 210, 175, 126, 48, 154, 190, 18, 192, 148, 190, 118, 134, 113, 245, 139, 0, 166, 244, 171, 31, 140, 166, 175, 4, 48, 165, 175, 157, 97, 92, 253, 34, 128, 41, 253, 234, 7, 163, 233, 43, 1, 76, 233, 107, 103, 24, 87, 191, 8, 96, 74, 191, 250, 193, 104, 250, 74, 0, 83, 250, 218, 25, 198, 213, 47, 2, 152, 210, 175, 126, 48, 154, 190, 18, 192, 148, 190, 118, 134, 113, 245, 139, 0, 166, 244, 171, 31, 140, 166, 175, 4, 48, 165, 175, 157, 97, 92, 253, 34, 128, 41, 253, 234, 7, 163, 233, 43, 1, 76, 233, 107, 103, 24, 87, 191, 152, 79, 187, 173, 0, 0, 22, 243, 73, 68, 65, 84, 8, 96, 74, 191, 250, 193, 104, 250, 74, 0, 83, 202, 117, 230, 221, 239, 255, 230, 131, 15, 63, 252, 237, 63, 117, 244, 223, 135, 31, 126, 240, 193, 111, 190, 63, 41, 55, 159, 216, 107, 198, 148, 18, 253, 255, 254, 111, 255, 250, 230, 171, 15, 4, 23, 146, 40, 80, 242, 224, 201, 119, 37, 63, 248, 143, 18, 179, 138, 189, 78, 76, 201, 220, 255, 189, 31, 124, 241, 53, 201, 197, 86, 10, 56, 50, 191, 202, 7, 175, 115, 149, 138, 188, 157, 197, 148, 156, 60, 239, 254, 105, 245, 117, 35, 230, 51, 220, 221, 237, 157, 175, 127, 126, 146, 115, 118, 177, 215, 133, 41, 217, 250, 191, 251, 167, 215, 186, 179, 64, 184, 165, 225, 235, 200, 146, 169, 193, 152, 146, 9, 228, 15, 158, 236, 77, 70, 194, 252, 118, 88, 54, 28, 60, 252, 55, 46, 22, 150, 163, 199, 152, 146, 131, 226, 222, 159, 94, 237, 163, 38, 215, 70, 190, 206, 117, 191, 219, 119, 25, 83, 218, 51, 220, 253, 195, 248, 58, 147, 125, 253, 247, 165, 255, 219, 126, 154, 193, 215, 128, 41, 109, 3, 224, 192, 147, 75, 127, 239, 112, 157, 252, 118, 157, 198, 148, 118, 252, 154, 255, 50, 250, 216, 68, 191, 247, 122, 248, 199, 150, 83, 141, 189, 56, 166, 180, 234, 255, 191, 143, 245, 137, 181, 91, 130, 95, 230, 110, 209, 108, 76, 105, 1, 239, 201, 175, 106, 141, 236, 114, 159, 176, 229, 225, 219, 147, 22, 211, 141, 189, 40, 166, 164, 247, 255, 125, 95, 154, 124, 100, 214, 206, 191, 164, 207, 55, 246, 146, 152, 146, 218, 255, 187, 223, 72, 248, 163, 222, 131, 69, 254, 231, 36, 117, 198, 177, 151, 195, 148, 196, 254, 123, 220, 161, 92, 121, 186, 195, 43, 251, 148, 158, 99, 74, 10, 181, 102, 247, 207, 61, 216, 59, 36, 15, 225, 237, 164, 57, 7, 95, 8, 83, 82, 2, 240, 195, 113, 114, 74, 123, 177, 224, 75, 103, 41, 179, 142, 189, 12, 166, 36, 244, 255, 253, 94, 196, 189, 205, 32, 120, 97, 175, 110, 59, 166, 168, 145, 237, 254, 115, 155, 140, 246, 101, 217, 111, 171, 231, 29, 124, 1, 76, 209, 6, 224, 238, 81, 95, 194, 222, 110, 28, 188, 7, 166, 235, 60, 166, 232, 120, 53, 207, 143, 218, 5, 180, 63, 75, 223, 57, 81, 78, 61, 118, 57, 166, 232, 250, 255, 189, 106, 68, 25, 12, 118, 166, 186, 185, 199, 174, 198, 20, 85, 255, 253, 191, 150, 159, 223, 167, 241, 186, 94, 209, 124, 76, 81, 192, 106, 126, 53, 159, 179, 10, 110, 15, 255, 174, 153, 125, 236, 90, 76, 81, 244, 255, 179, 21, 200, 177, 56, 133, 225, 55, 21, 211, 143, 93, 138, 41, 226, 254, 239, 85, 241, 238, 240, 162, 41, 131, 1, 170, 8, 3, 128, 41, 66, 80, 77, 83, 165, 40, 168, 34, 237, 63, 166, 72, 73, 85, 42, 10, 170, 8, 3, 128, 41, 50, 80, 123, 191, 91, 62, 108, 169, 231, 62, 7, 96, 146, 12, 96, 138, 132, 82, 211, 252, 190, 30, 49, 110, 205, 100, 248, 55, 25, 131, 216, 85, 152, 34, 234, 127, 109, 111, 15, 47, 218, 194, 155, 197, 130, 16, 96, 138, 0, 82, 243, 221, 197, 100, 85, 119, 111, 56, 149, 80, 136, 93, 131, 41, 130, 254, 127, 175, 58, 53, 150, 39, 52, 60, 19, 96, 136, 93, 130, 41, 219, 251, 255, 243, 209, 114, 176, 234, 187, 191, 115, 178, 157, 67, 236, 10, 76, 217, 218, 255, 247, 2, 136, 50, 24, 60, 55, 217, 10, 34, 118, 1, 166, 108, 235, 255, 238, 184, 190, 61, 200, 170, 25, 125, 101, 27, 136, 224, 207, 99, 202, 150, 0, 236, 93, 172, 138, 85, 141, 143, 253, 235, 22, 18, 193, 159, 198, 148, 45, 1, 168, 248, 19, 199, 37, 221, 135, 223, 218, 130, 34, 246, 211, 152, 178, 185, 255, 245, 191, 237, 53, 243, 101, 56, 221, 204, 34, 246, 179, 152, 178, 177, 255, 207, 207, 114, 20, 224, 22, 111, 128, 109, 8, 3, 166, 108, 128, 211, 68, 121, 53, 127, 253, 87, 224, 75, 155, 96, 4, 127, 14, 83, 54, 5, 224, 226, 58, 66, 81, 254, 253, 218, 38, 26, 177, 159, 195, 148, 13, 253, 175, 251, 108, 175, 85, 246, 15, 31, 111, 192, 17, 251, 41, 76, 89, 223, 255, 88, 47, 82, 174, 196, 225, 165, 202, 186, 60, 96, 202, 58, 50, 225, 94, 164, 92, 169, 194, 75, 149, 53, 129, 192, 148, 53, 96, 154, 102, 127, 213, 225, 73, 253, 143, 241, 82, 101, 117, 34, 48, 101, 53, 151, 166, 249, 113, 253, 82, 172, 156, 225, 112, 186, 142, 72, 236, 199, 49, 101, 77, 255, 239, 141, 86, 230, 40, 192, 131, 119, 38, 107, 144, 196, 126, 24, 83, 214, 244, 255, 40, 128, 19, 107, 166, 248, 242, 26, 36, 177, 31, 198, 148, 213, 253, 175, 253, 91, 142, 107, 36, 185, 122, 248, 96, 53, 147, 216, 143, 98, 202, 202, 254, 223, 219, 152, 164, 218, 159, 228, 248, 107, 69, 40, 48, 101, 5, 148, 102, 239, 168, 118, 25, 54, 207, 239, 229, 201, 42, 42, 177, 31, 195, 148, 85, 253, 15, 125, 236, 117, 41, 209, 116, 21, 149, 216, 143, 97, 202, 138, 254, 199, 125, 223, 235, 122, 87, 195, 241, 215, 173, 88, 96, 202, 45, 36, 77, 115, 113, 29, 152, 184, 255, 242, 254, 215, 114, 46, 48, 101, 153, 72, 220, 207, 28, 231, 255, 46, 112, 89, 163, 229, 92, 96, 202, 50, 145, 160, 231, 123, 205, 107, 114, 121, 251, 169, 91, 92, 130, 63, 128, 41, 183, 2, 240, 203, 229, 208, 196, 188, 127, 124, 11, 76, 236, 7, 48, 101, 185, 255, 17, 207, 181, 95, 245, 183, 128, 243, 239, 23, 147, 129, 41, 139, 60, 154, 230, 104, 85, 108, 34, 62, 198, 139, 250, 133, 104, 96, 202, 2, 14, 94, 206, 207, 254, 38, 12, 167, 75, 104, 98, 223, 197, 148, 197, 254, 71, 187, 198, 196, 76, 140, 219, 183, 158, 93, 68, 19, 252, 30, 166, 44, 6, 128, 151, 243, 115, 198, 60, 94, 100, 19, 251, 30, 166, 44, 244, 255, 238, 104, 46, 40, 225, 111, 222, 89, 96, 19, 252, 14, 166, 44, 4, 224, 60, 188, 29, 11, 0, 222, 88, 128, 19, 251, 14, 166, 204, 247, 159, 119, 136, 23, 68, 25, 236, 76, 230, 233, 196, 190, 141, 41, 243, 253, 191, 88, 12, 10, 247, 120, 167, 248, 38, 30, 152, 114, 131, 162, 105, 94, 64, 141, 37, 2, 195, 147, 57, 60, 177, 111, 98, 202, 172, 255, 209, 191, 191, 181, 100, 201, 71, 119, 191, 60, 195, 19, 252, 22, 166, 204, 2, 16, 245, 186, 69, 171, 12, 185, 126, 140, 115, 138, 175, 243, 129, 41, 215, 36, 154, 189, 241, 117, 60, 248, 119, 70, 224, 153, 27, 62, 193, 111, 96, 202, 77, 0, 216, 165, 204, 252, 152, 187, 53, 189, 1, 20, 251, 6, 166, 92, 247, 159, 93, 202, 156, 30, 115, 55, 57, 167, 229, 42, 33, 152, 114, 109, 10, 187, 148, 57, 61, 230, 111, 78, 175, 9, 197, 254, 23, 83, 62, 238, 63, 187, 148, 121, 59, 230, 111, 243, 243, 219, 31, 69, 4, 83, 62, 54, 133, 93, 202, 188, 29, 11, 183, 167, 31, 35, 138, 253, 15, 166, 92, 245, 159, 93, 202, 130, 28, 11, 119, 120, 251, 235, 50, 35, 152, 114, 101, 10, 187, 148, 5, 57, 22, 239, 156, 93, 49, 138, 253, 127, 76, 185, 234, 255, 120, 49, 27, 220, 155, 39, 192, 78, 229, 73, 72, 48, 229, 35, 83, 56, 227, 107, 222, 140, 229, 219, 124, 80, 143, 41, 87, 59, 20, 46, 51, 177, 236, 198, 210, 125, 78, 41, 102, 159, 114, 165, 10, 187, 148, 37, 53, 150, 238, 114, 74, 49, 166, 92, 153, 114, 177, 148, 12, 238, 46, 17, 120, 229, 122, 231, 27, 247, 95, 94, 167, 60, 233, 61, 95, 117, 92, 18, 227, 214, 93, 190, 252, 200, 43, 250, 203, 63, 146, 167, 183, 146, 193, 3, 75, 4, 142, 47, 57, 133, 254, 143, 125, 74, 211, 220, 93, 74, 5, 119, 111, 19, 224, 50, 45, 152, 210, 52, 223, 185, 29, 12, 30, 89, 38, 112, 16, 122, 135, 242, 100, 242, 152, 210, 236, 141, 150, 83, 193, 253, 219, 4, 194, 159, 124, 143, 41, 205, 103, 110, 199, 130, 71, 110, 19, 56, 11, 190, 83, 193, 20, 46, 110, 127, 219, 138, 85, 143, 68, 127, 163, 24, 83, 120, 139, 120, 149, 23, 183, 31, 139, 254, 70, 49, 166, 156, 223, 14, 5, 143, 172, 34, 112, 24, 251, 240, 43, 188, 41, 187, 163, 85, 169, 224, 177, 219, 4, 158, 195, 148, 208, 4, 126, 116, 59, 18, 60, 178, 154, 192, 52, 116, 80, 194, 239, 83, 198, 171, 83, 193, 163, 183, 9, 60, 141, 41, 129, 9, 188, 120, 59, 16, 60, 178, 134, 192, 112, 18, 56, 40, 225, 63, 121, 60, 95, 147, 10, 30, 94, 65, 224, 16, 83, 194, 18, 224, 245, 252, 10, 33, 214, 62, 20, 250, 53, 125, 240, 215, 41, 92, 104, 98, 173, 22, 171, 158, 56, 11, 251, 39, 53, 252, 121, 95, 71, 171, 242, 192, 99, 235, 8, 68, 254, 150, 112, 236, 125, 202, 189, 117, 145, 224, 241, 149, 4, 118, 216, 167, 4, 37, 240, 104, 101, 30, 120, 112, 45, 129, 227, 160, 65, 121, 50, 237, 208, 251, 20, 46, 28, 185, 86, 137, 53, 79, 4, 190, 70, 113, 104, 83, 184, 36, 203, 26, 33, 214, 62, 28, 248, 34, 45, 161, 77, 57, 95, 155, 8, 158, 88, 67, 224, 48, 236, 225, 87, 100, 83, 248, 48, 101, 141, 14, 27, 30, 142, 251, 145, 74, 100, 83, 248, 178, 227, 6, 37, 214, 61, 117, 22, 117, 167, 18, 217, 148, 253, 117, 105, 224, 241, 245, 4, 222, 192, 148, 112, 4, 118, 215, 199, 129, 103, 214, 18, 8, 123, 57, 163, 192, 251, 20, 206, 100, 89, 171, 195, 166, 39, 162, 30, 126, 5, 54, 229, 98, 83, 30, 120, 110, 29, 129, 168, 87, 158, 136, 107, 10, 7, 95, 235, 92, 216, 252, 120, 212, 195, 175, 184, 166, 112, 240, 181, 217, 136, 181, 207, 78, 195, 189, 162, 253, 104, 194, 113, 77, 57, 90, 27, 5, 158, 216, 72, 32, 232, 225, 87, 88, 83, 184, 108, 247, 70, 29, 54, 60, 25, 244, 240, 43, 172, 41, 124, 236, 184, 65, 134, 205, 79, 197, 124, 247, 43, 172, 41, 23, 155, 211, 192, 179, 235, 9, 196, 60, 252, 138, 106, 10, 239, 124, 173, 55, 97, 219, 51, 49, 15, 191, 162, 154, 194, 193, 215, 54, 31, 54, 60, 127, 18, 241, 221, 175, 168, 166, 156, 111, 8, 2, 79, 109, 33, 112, 136, 41, 97, 8, 240, 235, 66, 91, 100, 216, 248, 116, 200, 95, 29, 10, 186, 79, 225, 219, 142, 27, 85, 216, 242, 100, 200, 111, 62, 6, 53, 229, 209, 150, 44, 240, 244, 70, 2, 199, 97, 14, 62, 102, 19, 13, 106, 202, 120, 99, 16, 120, 114, 11, 129, 103, 102, 1, 10, 115, 43, 166, 41, 92, 231, 107, 139, 10, 91, 158, 142, 120, 221, 175, 152, 166, 240, 163, 41, 91, 84, 216, 246, 244, 65, 152, 93, 201, 205, 68, 99, 154, 114, 177, 45, 9, 60, 191, 153, 64, 192, 143, 233, 67, 154, 194, 7, 244, 155, 61, 216, 254, 108, 192, 75, 180, 132, 52, 133, 247, 136, 183, 187, 176, 165, 226, 228, 230, 168, 36, 202, 141, 144, 166, 156, 110, 137, 1, 79, 111, 37, 112, 28, 69, 144, 155, 121, 134, 52, 101, 188, 53, 8, 20, 108, 33, 16, 239, 125, 226, 136, 166, 240, 30, 241, 22, 13, 4, 79, 199, 123, 159, 56, 162, 41, 156, 71, 44, 80, 97, 91, 201, 217, 205, 97, 73, 144, 27, 17, 77, 57, 223, 150, 2, 158, 223, 78, 224, 141, 32, 130, 220, 76, 51, 162, 41, 163, 237, 57, 160, 98, 27, 129, 112, 231, 19, 7, 52, 229, 249, 109, 33, 224, 121, 1, 129, 225, 205, 31, 219, 32, 55, 2, 154, 194, 169, 44, 2, 17, 182, 151, 28, 4, 49, 228, 122, 154, 1, 77, 217, 223, 158, 2, 42, 182, 19, 184, 127, 29, 161, 32, 255, 198, 51, 133, 175, 59, 110, 183, 64, 82, 17, 237, 133, 74, 60, 83, 120, 153, 34, 241, 96, 123, 77, 180, 23, 42, 241, 76, 225, 101, 202, 118, 11, 68, 21, 7, 65, 14, 187, 62, 158, 102, 60, 83, 246, 69, 49, 160, 104, 43, 129, 251, 152, 82, 53, 1, 94, 166, 108, 85, 64, 88, 16, 236, 133, 74, 184, 125, 10, 47, 83, 132, 34, 108, 45, 11, 246, 66, 37, 156, 41, 159, 222, 154, 0, 10, 132, 4, 166, 85, 31, 124, 44, 79, 46, 156, 41, 231, 194, 24, 80, 182, 149, 192, 225, 114, 152, 170, 190, 31, 206, 148, 241, 214, 0, 80, 32, 36, 16, 235, 59, 42, 209, 76, 225, 7, 134, 132, 26, 8, 202, 238, 76, 170, 222, 137, 44, 77, 46, 154, 41, 124, 55, 69, 160, 128, 180, 228, 100, 41, 76, 85, 223, 141, 102, 202, 35, 105, 10, 168, 219, 78, 224, 184, 106, 53, 150, 38, 23, 205, 148, 163, 237, 253, 167, 66, 74, 224, 147, 75, 97, 170, 250, 110, 48, 83, 246, 164, 33, 160, 78, 64, 224, 169, 170, 213, 88, 154, 92, 48, 83, 94, 20, 244, 159, 18, 41, 129, 80, 159, 61, 6, 51, 133, 207, 29, 165, 22, 136, 234, 166, 75, 127, 119, 107, 190, 27, 203, 148, 189, 83, 81, 0, 40, 18, 18, 56, 172, 89, 141, 165, 185, 197, 50, 165, 25, 11, 35, 64, 153, 136, 64, 164, 207, 30, 99, 153, 194, 165, 187, 69, 2, 136, 139, 34, 253, 222, 118, 44, 83, 94, 24, 137, 67, 64, 161, 128, 64, 164, 151, 244, 177, 76, 225, 5, 189, 32, 254, 154, 146, 131, 165, 131, 249, 138, 239, 198, 50, 229, 92, 147, 2, 106, 183, 19, 56, 172, 88, 141, 165, 169, 197, 50, 101, 188, 189, 247, 84, 104, 8, 60, 189, 20, 167, 138, 239, 134, 50, 101, 119, 164, 73, 1, 181, 219, 9, 4, 122, 73, 31, 202, 20, 62, 161, 223, 158, 125, 93, 69, 160, 151, 244, 161, 76, 225, 148, 123, 157, 7, 130, 234, 105, 197, 199, 91, 139, 83, 11, 101, 202, 169, 160, 245, 148, 168, 8, 28, 47, 198, 169, 226, 123, 161, 76, 57, 82, 133, 128, 98, 1, 129, 56, 39, 222, 135, 50, 101, 36, 104, 61, 37, 42, 2, 113, 78, 188, 143, 100, 10, 191, 239, 168, 146, 64, 84, 28, 231, 247, 30, 35, 153, 194, 207, 208, 139, 194, 175, 43, 58, 169, 248, 165, 201, 194, 212, 34, 153, 242, 142, 46, 3, 84, 75, 8, 28, 44, 196, 169, 226, 59, 145, 76, 57, 151, 116, 158, 26, 29, 129, 195, 138, 229, 88, 152, 90, 36, 83, 142, 116, 25, 160, 90, 66, 32, 204, 249, 44, 129, 76, 225, 106, 19, 146, 228, 107, 107, 194, 188, 249, 21, 200, 20, 222, 250, 210, 90, 32, 169, 223, 153, 44, 28, 163, 212, 123, 39, 144, 41, 188, 245, 37, 73, 190, 186, 230, 164, 94, 57, 22, 102, 22, 200, 148, 119, 212, 33, 96, 1, 1, 129, 131, 133, 60, 213, 123, 39, 144, 41, 231, 130, 182, 83, 162, 38, 112, 88, 175, 28, 11, 51, 11, 100, 202, 145, 58, 4, 44, 32, 32, 16, 229, 204, 175, 64, 166, 140, 4, 109, 167, 68, 77, 32, 202, 207, 61, 198, 49, 133, 43, 24, 169, 37, 16, 45, 16, 229, 107, 143, 113, 76, 225, 11, 143, 162, 224, 171, 139, 162, 124, 237, 49, 142, 41, 124, 225, 81, 45, 129, 108, 129, 179, 133, 23, 190, 213, 222, 137, 99, 202, 59, 178, 190, 83, 165, 37, 240, 184, 90, 57, 22, 38, 22, 199, 148, 115, 109, 2, 168, 151, 17, 56, 92, 8, 84, 181, 119, 194, 152, 178, 119, 36, 235, 59, 85, 90, 2, 65, 222, 38, 14, 99, 74, 51, 210, 38, 128, 122, 25, 129, 32, 111, 19, 135, 49, 133, 55, 137, 101, 185, 215, 87, 5, 121, 155, 56, 140, 41, 207, 235, 35, 192, 18, 34, 2, 65, 222, 38, 14, 99, 10, 111, 18, 139, 98, 159, 80, 52, 60, 169, 246, 85, 252, 252, 196, 194, 152, 194, 15, 66, 36, 72, 32, 91, 100, 58, 31, 168, 106, 111, 135, 49, 229, 145, 172, 235, 84, 233, 9, 28, 87, 107, 199, 252, 196, 194, 152, 178, 175, 79, 0, 75, 200, 8, 220, 159, 15, 84, 181, 183, 163, 152, 194, 199, 41, 178, 212, 167, 84, 197, 184, 232, 68, 20, 83, 248, 56, 37, 197, 1, 217, 50, 49, 62, 80, 137, 98, 10, 31, 167, 200, 82, 159, 82, 21, 227, 3, 149, 40, 166, 112, 97, 150, 20, 7, 100, 203, 196, 184, 54, 113, 20, 83, 184, 48, 139, 44, 245, 73, 85, 147, 106, 95, 198, 207, 77, 44, 138, 41, 124, 240, 152, 228, 128, 108, 161, 179, 185, 64, 85, 123, 51, 138, 41, 239, 200, 122, 78, 85, 10, 129, 199, 213, 234, 49, 55, 177, 40, 166, 156, 166, 36, 128, 101, 100, 4, 142, 231, 2, 85, 237, 205, 40, 166, 236, 203, 122, 78, 85, 10, 129, 251, 213, 234, 49, 55, 177, 40, 166, 28, 165, 36, 128, 101, 100, 4, 66, 124, 151, 43, 138, 41, 35, 89, 207, 169, 74, 33, 240, 204, 220, 159, 222, 106, 111, 70, 49, 37, 37, 0, 44, 35, 36, 240, 92, 181, 122, 204, 77, 44, 136, 41, 119, 133, 61, 167, 44, 133, 64, 136, 15, 233, 131, 152, 194, 55, 30, 83, 12, 144, 46, 19, 226, 55, 84, 130, 152, 194, 71, 244, 210, 212, 39, 213, 205, 29, 164, 84, 123, 51, 136, 41, 124, 68, 159, 100, 128, 116, 161, 179, 106, 253, 152, 77, 44, 136, 41, 124, 55, 88, 26, 250, 164, 186, 233, 44, 80, 213, 222, 10, 98, 202, 163, 164, 0, 176, 144, 144, 192, 223, 171, 245, 99, 54, 177, 32, 166, 156, 10, 91, 78, 89, 18, 129, 195, 89, 160, 170, 189, 21, 196, 148, 253, 164, 0, 176, 144, 144, 192, 253, 106, 253, 152, 77, 44, 136, 41, 71, 194, 150, 83, 150, 68, 224, 19, 179, 64, 85, 123, 43, 136, 41, 227, 164, 0, 176, 144, 144, 64, 132, 211, 89, 48, 69, 24, 6, 202, 54, 16, 136, 112, 205, 137, 24, 166, 236, 109, 232, 50, 79, 181, 39, 240, 84, 181, 199, 92, 179, 137, 197, 48, 133, 43, 179, 180, 183, 97, 211, 26, 34, 156, 248, 21, 195, 20, 78, 144, 220, 148, 243, 246, 207, 69, 184, 58, 75, 12, 83, 56, 65, 178, 189, 13, 155, 214, 128, 41, 179, 163, 52, 223, 183, 56, 65, 114, 83, 206, 51, 60, 231, 59, 30, 162, 209, 199, 216, 167, 96, 74, 6, 27, 54, 173, 226, 68, 20, 54, 215, 69, 49, 76, 225, 84, 226, 77, 49, 207, 240, 220, 153, 107, 9, 68, 131, 143, 97, 10, 167, 18, 103, 176, 97, 211, 42, 166, 162, 176, 185, 46, 138, 97, 202, 167, 54, 117, 153, 231, 218, 19, 120, 236, 90, 2, 209, 224, 99, 152, 242, 168, 125, 22, 88, 195, 38, 2, 199, 162, 176, 185, 46, 138, 97, 202, 233, 166, 46, 243, 92, 123, 2, 152, 226, 250, 175, 192, 108, 240, 231, 237, 179, 192, 26, 54, 17, 56, 156, 177, 174, 245, 86, 140, 125, 202, 254, 166, 46, 243, 92, 123, 2, 247, 107, 245, 99, 54, 175, 24, 166, 92, 180, 207, 2, 107, 216, 68, 0, 83, 102, 74, 185, 190, 117, 180, 169, 203, 60, 215, 158, 192, 39, 92, 199, 67, 52, 248, 24, 251, 148, 113, 251, 44, 176, 134, 77, 4, 2, 252, 124, 112, 12, 83, 94, 221, 212, 101, 158, 107, 79, 0, 83, 68, 251, 165, 254, 23, 141, 219, 103, 129, 53, 108, 34, 16, 224, 235, 193, 49, 246, 41, 163, 77, 93, 230, 185, 246, 4, 2, 124, 61, 24, 83, 218, 199, 132, 53, 12, 2, 124, 61, 56, 134, 41, 100, 185, 48, 1, 76, 233, 255, 75, 16, 201, 8, 185, 224, 68, 97, 81, 6, 1, 190, 72, 31, 98, 159, 194, 5, 39, 74, 155, 18, 224, 87, 185, 66, 152, 194, 5, 39, 74, 155, 194, 62, 69, 114, 108, 211, 255, 26, 76, 41, 110, 202, 164, 255, 41, 104, 57, 66, 246, 41, 165, 67, 20, 98, 253, 1, 46, 206, 18, 194, 148, 123, 33, 210, 106, 57, 73, 76, 105, 185, 199, 234, 201, 226, 152, 82, 218, 162, 135, 61, 233, 116, 193, 97, 176, 79, 41, 29, 162, 16, 235, 103, 159, 82, 208, 209, 14, 87, 205, 37, 36, 75, 235, 138, 41, 29, 198, 185, 224, 166, 48, 165, 180, 41, 195, 130, 221, 235, 201, 170, 67, 28, 125, 97, 74, 105, 83, 216, 167, 244, 196, 231, 150, 195, 120, 177, 116, 80, 194, 175, 159, 125, 74, 203, 136, 246, 100, 113, 76, 41, 173, 50, 166, 244, 36, 234, 45, 135, 129, 41, 152, 210, 50, 66, 77, 19, 226, 117, 10, 166, 96, 10, 166, 72, 8, 96, 10, 166, 72, 114, 178, 177, 134, 125, 74, 233, 16, 133, 88, 63, 175, 83, 54, 90, 230, 230, 73, 246, 41, 165, 117, 197, 20, 55, 50, 108, 28, 40, 166, 96, 202, 198, 128, 72, 158, 228, 232, 171, 116, 136, 66, 172, 159, 125, 138, 68, 182, 254, 215, 176, 79, 41, 173, 43, 166, 244, 223, 2, 201, 8, 49, 5, 83, 36, 57, 217, 88, 195, 209, 87, 233, 16, 133, 88, 63, 251, 148, 141, 150, 185, 121, 146, 125, 74, 105, 93, 49, 197, 141, 12, 27, 7, 138, 41, 152, 178, 49, 32, 146, 39, 57, 250, 42, 29, 162, 16, 235, 103, 159, 34, 145, 173, 255, 53, 236, 83, 74, 235, 138, 41, 253, 183, 64, 50, 66, 76, 193, 20, 73, 78, 54, 214, 112, 244, 85, 58, 68, 33, 214, 207, 62, 101, 163, 101, 110, 158, 100, 159, 82, 90, 87, 76, 113, 35, 195, 198, 129, 98, 10, 166, 108, 12, 136, 228, 73, 142, 190, 74, 135, 40, 196, 250, 217, 167, 72, 100, 235, 127, 13, 251, 148, 210, 186, 98, 74, 255, 45, 144, 140, 16, 83, 48, 69, 146, 147, 141, 53, 28, 125, 149, 14, 81, 136, 245, 179, 79, 217, 104, 153, 155, 39, 217, 167, 148, 214, 21, 83, 220, 200, 176, 113, 160, 152, 130, 41, 27, 3, 34, 121, 146, 163, 175, 210, 33, 10, 177, 126, 246, 41, 18, 217, 250, 95, 195, 62, 165, 180, 174, 152, 210, 127, 11, 36, 35, 196, 20, 76, 145, 228, 100, 99, 13, 71, 95, 165, 67, 20, 98, 253, 236, 83, 54, 90, 230, 230, 73, 246, 41, 165, 117, 197, 20, 55, 50, 108, 28, 232, 221, 127, 226, 191, 178, 4, 190, 176, 145, 127, 21, 79, 134, 56, 250, 170, 162, 83, 76, 194, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 96, 138, 151, 78, 49, 78, 91, 2, 152, 98, 203, 159, 173, 123, 33, 128, 41, 94, 58, 197, 56, 109, 9, 96, 138, 45, 127, 182, 238, 133, 0, 166, 120, 233, 20, 227, 180, 37, 128, 41, 182, 252, 217, 186, 23, 2, 152, 226, 165, 83, 140, 211, 150, 0, 166, 216, 242, 103, 235, 94, 8, 124, 234, 255, 3, 16, 141, 187, 105, 9, 203, 153, 159, 0, 0, 0, 0, 73, 69, 78, 68, 174, 66, 96, 130 }, 50000m, "3a967595-44be-49ba-bea6-d8719b048ea4", new DateTime(2025, 5, 8, 14, 2, 5, 852, DateTimeKind.Local).AddTicks(2022), false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CurrencyId", "Description", "Image", "IsDisable", "MaxAdults", "MaxChildren", "Price", "RoomNumber", "RoomStatusId", "RoomTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(4971), 3, "Jednolůžkový pokoj s výhledem na zahradu", null, false, 1, 0, 2200m, "101", 1, 1, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5024) },
                    { 2, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5032), 3, "Dvoulůžkový pokoj", null, false, 2, 1, 2700m, "102", 1, 2, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5033) },
                    { 3, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5035), 3, "Třílůžkový pokoj s výhledem na moře", null, false, 3, 2, 3800m, "103", 1, 3, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5035) },
                    { 4, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5038), 3, "Rodinný pokoj", null, false, 4, 3, 4500m, "104", 1, 4, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5038) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1dab78de-fbe8-417d-b5ff-090a1cbd39a4", "7bea0c33-c854-48f3-a227-c0891b7e630b" });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "AppUserId", "CreatedAt", "CurrencyId", "Description", "Discount", "DueDate", "IsCanceled", "IsPaid", "IssueDate", "Prepayment", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "7bea0c33-c854-48f3-a227-c0891b7e630b", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5248), 3, "", 0.0m, new DateTime(2025, 6, 7, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5246), false, false, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5245), 0.0m, 1500.00m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5249) },
                    { 2, "7bea0c33-c854-48f3-a227-c0891b7e630b", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5256), 3, "", 0.0m, new DateTime(2025, 6, 7, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5255), false, true, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5254), 0.0m, 2500.00m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5257) },
                    { 3, "7bea0c33-c854-48f3-a227-c0891b7e630b", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5263), 3, "", 0.0m, new DateTime(2025, 6, 7, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5262), false, false, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5262), 0.0m, 1200.00m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5264) },
                    { 4, "7bea0c33-c854-48f3-a227-c0891b7e630b", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5271), 3, "", 0.0m, new DateTime(2025, 6, 7, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5270), false, true, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5269), 0.0m, 2000.00m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5272) },
                    { 5, "7bea0c33-c854-48f3-a227-c0891b7e630b", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5278), 3, "", 0.0m, new DateTime(2025, 6, 7, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5277), false, false, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5277), 0.0m, 1700.00m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5279) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "AdminNote", "Adults", "CheckIn", "CheckOut", "Children", "CreatedAt", "CurrencyId", "CustomerId", "IsCanceled", "MealPlanId", "ReservationStatusId", "RoomId", "SpecialRequest", "TotalPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Poznámka pro recepci", 1, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5196), 3, 1, false, 2, 1, 1, "Přistýlka", 6600m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5197) },
                    { 2, "Poznámka pro recepci", 2, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5203), 3, 2, false, 3, 1, 2, "Dětská postýlka", 13500m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5204) },
                    { 3, "Poznámka pro recepci", 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5210), 3, 3, false, 4, 1, 3, "Bezlepková dieta", 19000m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5211) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "CustomerId", "Rating", "RoomId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Skvělý pobyt, čistota na jedničku!", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5548), 1, 5, 1, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5549) },
                    { 2, "Příjemný personál a dobré jídlo.", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5552), 2, 4, 2, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5553) },
                    { 3, "Hezký pokoj, ale trochu hlučný soused.", new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5556), 3, 3, 3, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5557) }
                });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "Id", "Description", "InvoiceId", "Price" },
                values: new object[,]
                {
                    { 1, "Pokoj 101 (minibar)", 1, 6600m },
                    { 2, "Restaurace", 1, 500m },
                    { 3, "Pokoj 102 (minibar)", 2, 13500m },
                    { 4, "Bar", 2, 2500m }
                });

            migrationBuilder.InsertData(
                table: "InvoiceReservations",
                columns: new[] { "Id", "CreatedAt", "InvoiceId", "ReservationId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5336), 1, 1, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5337) },
                    { 2, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5362), 2, 2, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5363) },
                    { 3, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5365), 3, 3, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5365) }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "CreatedAt", "InvoiceId", "PaymentDate", "PaymentMethodId", "TotalAmount", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a6838ff2-7309-429f-ae1e-36790e0aaf09"), new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5507), 1, new DateTime(2025, 5, 3, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5505), 1, 7100m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5508) },
                    { new Guid("ad0a30cd-441d-4d72-b4bc-b5ec539f3178"), new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5519), 2, new DateTime(2025, 4, 28, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5518), 2, 16000m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5520) }
                });

            migrationBuilder.InsertData(
                table: "ReservationCustomers",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "IsMainGuest", "ReservationId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5420), 6, false, 1, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5421) },
                    { 2, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5427), 1, true, 1, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5428) },
                    { 3, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5429), 2, true, 2, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5430) },
                    { 4, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5431), 7, false, 2, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5432) },
                    { 5, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5433), 3, true, 3, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5434) },
                    { 6, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5435), 8, false, 3, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5436) }
                });

            migrationBuilder.InsertData(
                table: "ReservationServices",
                columns: new[] { "Id", "CreatedAt", "Note", "OriginalUnitPrice", "Quantity", "ReservationId", "ServiceId", "UnitPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5390), "Wellness pro 1 osobu", 0m, 1, 1, 1, 500m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5391) },
                    { 2, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5398), "Parkování po celou dobu", 0m, 6, 2, 2, 250m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5398) },
                    { 3, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5400), "Pes na pokoji", 0m, 11, 3, 3, 300m, new DateTime(2025, 5, 8, 14, 2, 5, 888, DateTimeKind.Local).AddTicks(5400) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CurrencyId",
                table: "AspNetUsers",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_InsuranceCompanyId",
                table: "AspNetUsers",
                column: "InsuranceCompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceReservations_InvoiceId",
                table: "InvoiceReservations",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceReservations_ReservationId",
                table: "InvoiceReservations",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_AppUserId",
                table: "Invoices",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CurrencyId",
                table: "Invoices",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_InvoiceId",
                table: "Payments",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationCustomers_CustomerId",
                table: "ReservationCustomers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationCustomers_ReservationId",
                table: "ReservationCustomers",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CurrencyId",
                table: "Reservations",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MealPlanId",
                table: "Reservations",
                column: "MealPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationStatusId",
                table: "Reservations",
                column: "ReservationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationServices_ReservationId",
                table: "ReservationServices",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationServices_ServiceId",
                table: "ReservationServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RoomId",
                table: "Reviews",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenities_AmenityId",
                table: "RoomAmenities",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CurrencyId",
                table: "Rooms",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomStatusId",
                table: "Rooms",
                column: "RoomStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_EmployeeId",
                table: "TaskItems",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "InvoiceReservations");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ReservationCustomers");

            migrationBuilder.DropTable(
                name: "ReservationServices");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RoomAmenities");

            migrationBuilder.DropTable(
                name: "TaskItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MealPlans");

            migrationBuilder.DropTable(
                name: "ReservationStatuses");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "InsuranceCompanies");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "RoomStatuses");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
