using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

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
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Symbol = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    DocumentNumber = table.Column<string>(type: "longtext", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "longtext", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PersonalIdentificationNumber = table.Column<string>(type: "longtext", nullable: false),
                    Nationality = table.Column<string>(type: "longtext", nullable: false),
                    Phone = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false),
                    City = table.Column<string>(type: "longtext", nullable: false),
                    PostalCode = table.Column<string>(type: "longtext", nullable: false),
                    Country = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InsuranceCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Website = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompanies", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlans", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ReservationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationStatuses", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoomStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomStatuses", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "longblob", nullable: true),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false),
                    City = table.Column<string>(type: "longtext", nullable: false),
                    PostalCode = table.Column<string>(type: "longtext", nullable: false),
                    Country = table.Column<string>(type: "longtext", nullable: false),
                    PersonalIdentificationNumber = table.Column<string>(type: "longtext", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "longtext", nullable: false),
                    JobTitle = table.Column<string>(type: "longtext", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsEmployed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsuranceCompanyId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_InsuranceCompanies_InsuranceCompanyId",
                        column: x => x.InsuranceCompanyId,
                        principalTable: "InsuranceCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoomNumber = table.Column<string>(type: "longtext", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    RoomStatusId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<byte[]>(type: "longblob", nullable: true),
                    MaxAdults = table.Column<int>(type: "int", nullable: false),
                    MaxChildren = table.Column<int>(type: "int", nullable: false),
                    IsDisable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReservationStatusId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Adults = table.Column<int>(type: "int", nullable: false),
                    Children = table.Column<int>(type: "int", nullable: false),
                    MealPlanId = table.Column<int>(type: "int", nullable: false),
                    SpecialRequest = table.Column<string>(type: "longtext", nullable: false),
                    AdminNote = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DocumentNumber = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ReservationId = table.Column<int>(type: "int", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prepayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsCanceled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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
                    { 1, "Hlavní 123", "Praha", "Česká republika", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5899), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725912987", "jan.novak@example.com", "Jan", "Novák", "Česká republika", "CZ1234567890", "+420123456789", "Praha", "11000", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5901) },
                    { 2, "Náměstí 456", "Brno", "Česká republika", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5909), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2029, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725912298", "petr.svoboda@example.com", "Petr", "Svoboda", "Česká republika", "CZ0987654321", "+420987654321", "Brno", "60200", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5910) },
                    { 3, "Sokolská 789", "Ostrava", "Česká republika", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5918), new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420745912987", "marie.cerna@example.com", "Marie", "Černá", "Česká republika", "CZ4567891234", "+420654789123", "Ostrava", "70200", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5919) },
                    { 4, "Jasná 321", "Plzeň", "Česká republika", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5926), new DateTime(1988, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2032, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725612987", "anna.havlickova@example.com", "Anna", "Havlíčková", "Česká republika", "CZ3216549870", "+420321654987", "Plzeň", "30100", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5927) },
                    { 5, "Květná 159", "Liberec", "Česká republika", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5935), new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725922987", "tomas.prochazka@example.com", "Tomáš", "Procházka", "Česká republika", "CZ1597534680", "+420159753468", "Liberec", "46000", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5936) },
                    { 6, "Lípa 753", "Ústí nad Labem", "Česká republika", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5944), new DateTime(1998, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725912387", "petra.dvorakova@example.com", "Petra", "Dvořáková", "Česká republika", "CZ7539518520", "+420753951852", "Ústí nad Labem", "40000", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5945) },
                    { 7, "Březová 852", "Hradec Králové", "Česká republika", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5952), new DateTime(1987, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420725112987", "jakub.novotny@example.com", "Jakub", "Novotný", "Česká republika", "CZ8524567890", "+420852456789", "Hradec Králové", "50000", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5953) },
                    { 8, "Růžová 258", "Zlín", "Česká republika", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6025), new DateTime(1993, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420025912987", "lucie.krejcova@example.com", "Lucie", "Krejčová", "Česká republika", "CZ2589631470", "+420258963147", "Zlín", "76000", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6027) },
                    { 9, "Modrá 369", "Karlovy Vary", "Česká republika", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6035), new DateTime(1980, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2028, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420723912987", "martin.fiala@example.com", "Martin", "Fiala", "Česká republika", "CZ3692581470", "+420369258147", "Karlovy Vary", "36000", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6036) },
                    { 10, "Violetová 741", "Jihlava", "Česká republika", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6043), new DateTime(1991, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2031, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "+420225912987", "barbora.kovarova@example.com", "Barbora", "Kovářová", "Česká republika", "CZ7418529630", "+420741852963", "Jihlava", "58601", new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6044) }
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "InsuranceCompanyId", "IsEmployed", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalIdentificationNumber", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfBirth", "PostalCode", "ProfilePicture", "Salary", "SecurityStamp", "StartDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "19329d22-ce24-42ab-a8d7-db7255a28384", 0, "Hlavní 123", "Praha", "06301ce2-930a-46bb-96db-9870eb5aaab0", "Česká republika", "admin@admin.com", true, "Admin", 1, true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENY2mv1A/0bDdONUysTG4Jos7xQP6vPFhum82MRIfpUAcwYxwbm8THkGRTUloRiqXQ==", "CZ1234567890", null, false, "Praha", "11000", null, 50000m, "7b3a268d-cb24-496e-94e2-2750c93f141c", new DateTime(2025, 2, 13, 15, 8, 47, 509, DateTimeKind.Local).AddTicks(956), false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDisable", "MaxAdults", "MaxChildren", "Price", "RoomNumber", "RoomStatusId", "RoomTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5766), "Jednolůžkový pokoj s výhledem na zahradu", null, false, 1, 0, 2200m, "101", 1, 1, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5826) },
                    { 2, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5834), "Dvoulůžkový pokoj", null, false, 2, 1, 2700m, "102", 1, 2, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5835) },
                    { 3, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5837), "Třílůžkový pokoj s výhledem na moře", null, false, 3, 2, 3800m, "103", 1, 3, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5838) },
                    { 4, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5840), "Rodinný pokoj", null, false, 4, 3, 4500m, "104", 1, 4, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(5841) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "AdminNote", "Adults", "CheckIn", "CheckOut", "Children", "CreatedAt", "CustomerId", "MealPlanId", "ReservationStatusId", "RoomId", "SpecialRequest", "TotalPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Poznámka pro recepci", 1, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6092), 1, 2, 1, 1, "Přistýlka", 6600m, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6093) },
                    { 2, "Poznámka pro recepci", 2, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6099), 2, 3, 1, 2, "Dětská postýlka", 13500m, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6100) },
                    { 3, "Poznámka pro recepci", 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6106), 3, 4, 1, 3, "Bezlepková dieta", 19000m, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6107) },
                    { 4, "Poznámka pro recepci", 4, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6113), 4, 4, 1, 4, "Elktro mobil", 22500m, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6114) },
                    { 5, "Poznámka pro recepci", 1, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6120), 5, 2, 1, 1, "Přistýlka", 6600m, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6121) }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedAt", "CurrencyId", "Description", "Discount", "DueDate", "IsCanceled", "IsPaid", "IssueDate", "Prepayment", "Price", "ReservationId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6159), 1, "", 0.0m, new DateTime(2025, 3, 15, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6157), false, false, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6155), 0.0m, 1500.00m, 1, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6160) },
                    { 2, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6168), 1, "", 0.0m, new DateTime(2025, 3, 15, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6166), false, true, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6165), 0.0m, 2500.00m, 2, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6169) },
                    { 3, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6176), 1, "", 0.0m, new DateTime(2025, 3, 15, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6175), false, false, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6174), 0.0m, 1200.00m, 3, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6177) },
                    { 4, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6185), 1, "", 0.0m, new DateTime(2025, 3, 15, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6184), false, true, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6183), 0.0m, 2000.00m, 4, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6186) },
                    { 5, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6194), 1, "", 0.0m, new DateTime(2025, 3, 15, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6193), false, false, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6192), 0.0m, 1700.00m, 5, new DateTime(2025, 2, 13, 15, 8, 47, 544, DateTimeKind.Local).AddTicks(6195) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                name: "IX_AspNetUsers_InsuranceCompanyId",
                table: "AspNetUsers",
                column: "InsuranceCompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guests_ReservationId",
                table: "Guests",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CurrencyId",
                table: "Invoices",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ReservationId",
                table: "Invoices",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_InvoiceId",
                table: "Payments",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId");

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
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Payments");

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
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "InsuranceCompanies");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MealPlans");

            migrationBuilder.DropTable(
                name: "ReservationStatuses");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomStatuses");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
