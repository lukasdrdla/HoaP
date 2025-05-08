using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Services;
using HoaP.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationStatus> ReservationStatuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomStatus> RoomStatuses { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<RoomAmenity> RoomAmenities { get; set; }
        public DbSet<ReservationCustomer> ReservationCustomers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceReservation> ReservationServices { get; set; }
        public DbSet<InvoiceReservation> InvoiceReservations { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<InvoiceReservation>()
            .HasOne(ir => ir.Invoice)
            .WithMany(i => i.InvoiceReservations)
            .HasForeignKey(ir => ir.InvoiceId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<InvoiceReservation>()
                .HasOne(ir => ir.Reservation)
                .WithMany(r => r.InvoiceReservations)
                .HasForeignKey(ir => ir.ReservationId)
                .OnDelete(DeleteBehavior.Restrict);



            builder.Entity<RoomAmenity>()
            .HasKey(ra => new { ra.RoomId, ra.AmenityId });

            builder.Entity<Currency>()
                .Property(c => c.Rate)
                .HasPrecision(18, 6);

            builder.Entity<Reservation>()
                .Property(r => r.TotalPrice)
                .HasPrecision(18, 2);

            builder.Entity<Service>()
                .Property(s => s.Price)
                .HasPrecision(18, 2);

            builder.Entity<ServiceReservation>()
                .Property(s => s.UnitPrice)
                .HasPrecision(18, 2);

            builder.Entity<MealPlan>()
                .Property(m => m.Price)
                .HasPrecision(18, 2);

            builder.Entity<InvoiceItem>()
                .Property(i => i.Price)
                .HasPrecision(18, 2);

            builder.Entity<Invoice>()
                .Property(i => i.Discount)
                .HasPrecision(18, 2);

            builder.Entity<Invoice>()
                .Property(i => i.Prepayment)
                .HasPrecision(18, 2);

            builder.Entity<Payment>()
                .Property(p => p.TotalAmount)
                .HasPrecision(18, 2);

            builder.Entity<AppUser>()
                .Property(u => u.Salary)
                .HasPrecision(18, 2);

            builder.Entity<Invoice>()
                .Property(i => i.Price)
                .HasPrecision(18, 2);

            builder.Entity<Room>()
                .Property(r => r.Price)
                .HasPrecision(18, 2);

            builder.Entity<AppUser>()
                .HasOne(u => u.Currency)
                .WithMany()
                .HasForeignKey(u => u.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AppUser>()
                .HasOne(u => u.InsuranceCompany)
                .WithMany()
                .HasForeignKey(u => u.InsuranceCompanyId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Room>()
                .HasOne(r => r.Currency)
                .WithMany()
                .HasForeignKey(r => r.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict); // nebo .NoAction


            SeedData(builder);
        }


        private void SeedData(ModelBuilder modelBuilder)
        {

           

            var adminRole = new AppRole { Id = Guid.NewGuid().ToString(), Name = "Admin", NormalizedName = "ADMIN" };
            var managerRole = new AppRole { Id = Guid.NewGuid().ToString(), Name = "Manager", NormalizedName = "MANAGER" };
            var receptionistRole = new AppRole { Id = Guid.NewGuid().ToString(), Name = "Receptionist", NormalizedName = "RECEPTIONIST" };

            modelBuilder.Entity<AppRole>().HasData(adminRole, managerRole, receptionistRole);

            var adminId = Guid.NewGuid().ToString();
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "admin.png");
            byte[]? profilePictureBytes = File.Exists(imagePath) ? File.ReadAllBytes(imagePath) : null;

            var admin = new AppUser
            {
                    Id = adminId,
                    UserName = "admin@admin.com",
                    NormalizedUserName = "ADMIN@ADMIN.COM",
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Admin",
                    ProfilePicture = profilePictureBytes,
                    LastName = "Admin",
                    Address = "Hlavní 123",
                    City = "Praha",
                    PostalCode = "11000",
                    Country = "Česká republika",
                    PersonalIdentificationNumber = "CZ1234567890",
                    PlaceOfBirth = "Praha",
                    JobTitle = "Admin",
                    StartDate = DateTime.Now,
                    Salary = 50000,
                    IsEmployed = true,
                    InsuranceCompanyId = 1
            };

            var passwordHasher = new PasswordHasher<AppUser>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin123456789!");

            modelBuilder.Entity<AppUser>().HasData(admin);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = adminId
            });




            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = 1, Name = "Americký dolar", Symbol = "$", Code = "USD", Rate = 22.50m },
                new Currency { Id = 2, Name = "Euro", Symbol = "€", Code = "EUR", Rate = 24.80m },
                new Currency { Id = 3, Name = "Česká koruna", Symbol = "Kč", Code = "CZK", Rate = 1.00m }
            );


            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod { Id = 1, Name = "Hotově" },
                new PaymentMethod { Id = 2, Name = "Kartou" },
                new PaymentMethod { Id = 3, Name = "Převodem" }
            );

            modelBuilder.Entity<RoomStatus>().HasData(
                new RoomStatus { Id = 1, Name = "Volný" },
                new RoomStatus { Id = 2, Name = "Obsazený" },
                new RoomStatus { Id = 3, Name = "Mimo provoz" },
                new RoomStatus { Id = 4, Name = "Čeká na úklid" }
            );

            modelBuilder.Entity<ReservationStatus>().HasData(
                new ReservationStatus { Id = 1, Name = "Potvrzená" },
                new ReservationStatus { Id = 2, Name = "Zrušená" }
            );

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Name = "Jednolůžkový pokoj" },
                new RoomType { Id = 2, Name = "Dvoulůžkový pokoj" },
                new RoomType { Id = 3, Name = "Třílůžkový pokoj" },
                new RoomType { Id = 4, Name = "Rodinný pokoj" }
            );

            modelBuilder.Entity<MealPlan>().HasData(
                new MealPlan { Id = 1, Name = "Bez stravy" },
                new MealPlan { Id = 2, Name = "Snídaně" },
                new MealPlan { Id = 3, Name = "Polopenze" },
                new MealPlan { Id = 4, Name = "Plná penze" }
            );

            modelBuilder.Entity<InsuranceCompany>().HasData(
                new InsuranceCompany { Id = 1, Name = "Česká pojišťovna" },
                new InsuranceCompany { Id = 2, Name = "Kooperativa" },
                new InsuranceCompany { Id = 3, Name = "Allianz" }
            );

            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, RoomNumber = "101", RoomTypeId = 1, RoomStatusId = 1, Description = "Jednolůžkový pokoj s výhledem na zahradu", Price = 2200, CurrencyId = 3, MaxAdults = 1, MaxChildren = 0 },
                new Room { Id = 2, RoomNumber = "102", RoomTypeId = 2, RoomStatusId = 1, Description = "Dvoulůžkový pokoj", Price = 2700, MaxAdults = 2, CurrencyId = 3, MaxChildren = 1 },
                new Room { Id = 3, RoomNumber = "103", RoomTypeId = 3, RoomStatusId = 1, Description = "Třílůžkový pokoj s výhledem na moře", Price = 3800, CurrencyId = 3, MaxAdults = 3, MaxChildren = 2 },
                new Room { Id = 4, RoomNumber = "104", RoomTypeId = 4, RoomStatusId = 1, Description = "Rodinný pokoj", Price = 4500, MaxAdults = 4, MaxChildren = 3, CurrencyId = 3 }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "Jan", LastName = "Novák", DocumentNumber = "+420725912987", PlaceOfBirth = "Praha", DateOfBirth = new DateTime(1990, 1, 1), DateOfIssue = new DateTime(2020, 1, 1), DateOfExpiry = new DateTime(2030, 1, 1), PersonalIdentificationNumber = "CZ1234567890", Nationality = "Česká republika", Phone = "+420123456789", Email = "jan.novak@example.com", Address = "Hlavní 123", City = "Praha", PostalCode = "11000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 2, FirstName = "Petr", LastName = "Svoboda", DocumentNumber = "+420725912298", PlaceOfBirth = "Brno", DateOfBirth = new DateTime(1985, 5, 15), DateOfIssue = new DateTime(2019, 6, 10), DateOfExpiry = new DateTime(2029, 6, 10), PersonalIdentificationNumber = "CZ0987654321", Nationality = "Česká republika", Phone = "+420987654321", Email = "petr.svoboda@example.com", Address = "Náměstí 456", City = "Brno", PostalCode = "60200", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 3, FirstName = "Marie", LastName = "Černá", DocumentNumber = "+420745912987", PlaceOfBirth = "Ostrava", DateOfBirth = new DateTime(1992, 3, 25), DateOfIssue = new DateTime(2021, 7, 20), DateOfExpiry = new DateTime(2031, 7, 20), PersonalIdentificationNumber = "CZ4567891234", Nationality = "Česká republika", Phone = "+420654789123", Email = "marie.cerna@example.com", Address = "Sokolská 789", City = "Ostrava", PostalCode = "70200", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 4, FirstName = "Anna", LastName = "Havlíčková", DocumentNumber = "+420725612987", PlaceOfBirth = "Plzeň", DateOfBirth = new DateTime(1988, 8, 30), DateOfIssue = new DateTime(2022, 4, 15), DateOfExpiry = new DateTime(2032, 4, 15), PersonalIdentificationNumber = "CZ3216549870", Nationality = "Česká republika", Phone = "+420321654987", Email = "anna.havlickova@example.com", Address = "Jasná 321", City = "Plzeň", PostalCode = "30100", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 5, FirstName = "Tomáš", LastName = "Procházka", DocumentNumber = "+420725922987", PlaceOfBirth = "Liberec", DateOfBirth = new DateTime(1995, 12, 12), DateOfIssue = new DateTime(2021, 11, 11), DateOfExpiry = new DateTime(2031, 11, 11), PersonalIdentificationNumber = "CZ1597534680", Nationality = "Česká republika", Phone = "+420159753468", Email = "tomas.prochazka@example.com", Address = "Květná 159", City = "Liberec", PostalCode = "46000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 6, FirstName = "Petra", LastName = "Dvořáková", DocumentNumber = "+420725912387", PlaceOfBirth = "Ústí nad Labem", DateOfBirth = new DateTime(1998, 10, 20), DateOfIssue = new DateTime(2020, 8, 15), DateOfExpiry = new DateTime(2030, 8, 15), PersonalIdentificationNumber = "CZ7539518520", Nationality = "Česká republika", Phone = "+420753951852", Email = "petra.dvorakova@example.com", Address = "Lípa 753", City = "Ústí nad Labem", PostalCode = "40000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 7, FirstName = "Jakub", LastName = "Novotný", DocumentNumber = "+420725112987", PlaceOfBirth = "Hradec Králové", DateOfBirth = new DateTime(1987, 4, 5), DateOfIssue = new DateTime(2021, 5, 1), DateOfExpiry = new DateTime(2031, 5, 1), PersonalIdentificationNumber = "CZ8524567890", Nationality = "Česká republika", Phone = "+420852456789", Email = "jakub.novotny@example.com", Address = "Březová 852", City = "Hradec Králové", PostalCode = "50000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 8, FirstName = "Lucie", LastName = "Krejčová", DocumentNumber = "+420025912987", PlaceOfBirth = "Zlín", DateOfBirth = new DateTime(1993, 11, 11), DateOfIssue = new DateTime(2021, 3, 12), DateOfExpiry = new DateTime(2031, 3, 12), PersonalIdentificationNumber = "CZ2589631470", Nationality = "Česká republika", Phone = "+420258963147", Email = "lucie.krejcova@example.com", Address = "Růžová 258", City = "Zlín", PostalCode = "76000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 9, FirstName = "Martin", LastName = "Fiala", DocumentNumber = "+420723912987", PlaceOfBirth = "Karlovy Vary", DateOfBirth = new DateTime(1980, 9, 9), DateOfIssue = new DateTime(2018, 4, 20), DateOfExpiry = new DateTime(2028, 4, 20), PersonalIdentificationNumber = "CZ3692581470", Nationality = "Česká republika", Phone = "+420369258147", Email = "martin.fiala@example.com", Address = "Modrá 369", City = "Karlovy Vary", PostalCode = "36000", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Customer { Id = 10, FirstName = "Barbora", LastName = "Kovářová", DocumentNumber = "+420225912987", PlaceOfBirth = "Jihlava", DateOfBirth = new DateTime(1991, 6, 15), DateOfIssue = new DateTime(2021, 9, 15), DateOfExpiry = new DateTime(2031, 9, 15), PersonalIdentificationNumber = "CZ7418529630", Nationality = "Česká republika", Phone = "+420741852963", Email = "barbora.kovarova@example.com", Address = "Violetová 741", City = "Jihlava", PostalCode = "58601", Country = "Česká republika", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, RoomId = 1, CheckIn = new DateTime(2025, 1, 4), CheckOut = new DateTime(2025, 1, 10), TotalPrice = 6600, ReservationStatusId = 1, CustomerId = 1, Adults = 1, Children = 0, MealPlanId = 2, SpecialRequest = "Přistýlka", AdminNote = "Poznámka pro recepci", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CurrencyId = 3 },
                new Reservation { Id = 2, RoomId = 2, CheckIn = new DateTime(2025, 1, 2), CheckOut = new DateTime(2025, 1, 8), TotalPrice = 13500, ReservationStatusId = 1, CustomerId = 2, Adults = 2, Children = 1, MealPlanId = 3, SpecialRequest = "Dětská postýlka", AdminNote = "Poznámka pro recepci", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CurrencyId = 3 },
                new Reservation { Id = 3, RoomId = 3, CheckIn = new DateTime(2025, 1, 1), CheckOut = new DateTime(2025, 1, 12), TotalPrice = 19000, ReservationStatusId = 1, CustomerId = 3, Adults = 3, Children = 2, MealPlanId = 4, SpecialRequest = "Bezlepková dieta", AdminNote = "Poznámka pro recepci", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CurrencyId = 3 }
                );

            modelBuilder.Entity<Invoice>().HasData(
                new Invoice { Id = 1, AppUserId = adminId, CurrencyId = 3, IssueDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30), Price = 1500.00m, IsPaid = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Invoice { Id = 2, AppUserId = adminId, CurrencyId = 3, IssueDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30), Price = 2500.00m, IsPaid = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Invoice { Id = 3, AppUserId = adminId, CurrencyId = 3, IssueDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30), Price = 1200.00m, IsPaid = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Invoice { Id = 4, AppUserId = adminId, CurrencyId = 3, IssueDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30), Price = 2000.00m, IsPaid = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new Invoice { Id = 5, AppUserId = adminId, CurrencyId = 3, IssueDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30), Price = 1700.00m, IsPaid = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now}
                );
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Wellness vstup", Price = 500, IsPerNight = false },
                new Service { Id = 2, Name = "Parkování", Price = 250, IsPerNight = true },
                new Service { Id = 3, Name = "Domácí mazlíček", Price = 300, IsPerNight = true },
                new Service { Id = 4, Name = "Služba žehlení", Price = 150, IsPerNight = false }
            );

            modelBuilder.Entity<InvoiceReservation>().HasData(
                new InvoiceReservation { Id = 1, InvoiceId = 1, ReservationId = 1},
                new InvoiceReservation { Id = 2, InvoiceId = 2, ReservationId = 2},
                new InvoiceReservation { Id = 3, InvoiceId = 3, ReservationId = 3 }
            );


            modelBuilder.Entity<ServiceReservation>().HasData(
                new ServiceReservation { Id = 1, ReservationId = 1, ServiceId = 1, Quantity = 1, UnitPrice = 500, Note = "Wellness pro 1 osobu" },
                new ServiceReservation { Id = 2, ReservationId = 2, ServiceId = 2, Quantity = 6, UnitPrice = 250, Note = "Parkování po celou dobu" },
                new ServiceReservation { Id = 3, ReservationId = 3, ServiceId = 3, Quantity = 11, UnitPrice = 300, Note = "Pes na pokoji" }
            );

            modelBuilder.Entity<ReservationCustomer>().HasData(
                new ReservationCustomer { Id = 1, ReservationId = 1, CustomerId = 6, IsMainGuest = false },
                new ReservationCustomer { Id = 2, ReservationId = 1, CustomerId = 1, IsMainGuest = true },
                new ReservationCustomer { Id = 3, ReservationId = 2, CustomerId = 2, IsMainGuest = true },
                new ReservationCustomer { Id = 4, ReservationId = 2, CustomerId = 7, IsMainGuest = false },
                new ReservationCustomer { Id = 5, ReservationId = 3, CustomerId = 3, IsMainGuest = true },
                new ReservationCustomer { Id = 6, ReservationId = 3, CustomerId = 8, IsMainGuest = false }

            );

            modelBuilder.Entity<InvoiceItem>().HasData(
                new InvoiceItem { Id = 1, InvoiceId = 1, Description = "Pokoj 101 (minibar)", Price = 6600 },
                new InvoiceItem { Id = 2, InvoiceId = 1, Description = "Restaurace", Price = 500 },
                new InvoiceItem { Id = 3, InvoiceId = 2, Description = "Pokoj 102 (minibar)", Price = 13500 },
                new InvoiceItem { Id = 4, InvoiceId = 2, Description = "Bar", Price = 2500 }
            );

            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = Guid.NewGuid(), InvoiceId = 1, TotalAmount = 7100, PaymentDate = DateTime.Now.AddDays(-5), PaymentMethodId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Payment { Id = Guid.NewGuid(), InvoiceId = 2, TotalAmount = 16000, PaymentDate = DateTime.Now.AddDays(-10), PaymentMethodId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, CustomerId = 1, RoomId = 1, Rating = 5, Comment = "Skvělý pobyt, čistota na jedničku!", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Review { Id = 2, CustomerId = 2, RoomId = 2, Rating = 4, Comment = "Příjemný personál a dobré jídlo.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Review { Id = 3, CustomerId = 3, RoomId = 3, Rating = 3, Comment = "Hezký pokoj, ale trochu hlučný soused.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );







        }
    }
}
