using System;
using System.Text.Json;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HoaP.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        private readonly IEncryptionService? _encryptionService;
        private readonly IHttpContextAccessor? _httpContextAccessor;

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IEncryptionService? encryptionService = null,
            IHttpContextAccessor? httpContextAccessor = null) : base(options)
        {
            _encryptionService = encryptionService;
            _httpContextAccessor = httpContextAccessor;
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
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<HotelProfile> HotelProfiles { get; set; }
        public DbSet<ReservationSource> ReservationSources { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<RatePlan> RatePlans { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(w =>
                w.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Sifrovani citlivych dat (GDPR)
            if (_encryptionService != null)
            {
                var encryptedStringConverter = new ValueConverter<string, string>(
                    v => _encryptionService.Encrypt(v),
                    v => _encryptionService.Decrypt(v));

                builder.Entity<Customer>()
                    .Property(c => c.PersonalIdentificationNumber)
                    .HasConversion(encryptedStringConverter);

                builder.Entity<Customer>()
                    .Property(c => c.DocumentNumber)
                    .HasConversion(encryptedStringConverter);
            }

            builder.Entity<Reservation>()
                .HasOne(r => r.Invoice)
                .WithMany(i => i.Reservations)
                .HasForeignKey(r => r.InvoiceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Payment>()
                .HasOne(p => p.Invoice)
                .WithMany(i => i.Payments)
                .HasForeignKey(p => p.InvoiceId)
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

            builder.Entity<InvoiceItem>()
                .Property(i => i.UnitPrice)
                .HasPrecision(18, 2);

            builder.Entity<InvoiceItem>()
                .Property(i => i.VatRate)
                .HasPrecision(5, 2);

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
                .OnDelete(DeleteBehavior.Restrict);


            // Indexy pro caste dotazy
            builder.Entity<Reservation>()
                .HasIndex(r => new { r.RoomId, r.CheckIn, r.CheckOut })
                .HasDatabaseName("IX_Reservation_Room_Dates");

            builder.Entity<Reservation>()
                .HasIndex(r => r.CustomerId)
                .HasDatabaseName("IX_Reservation_CustomerId");

            builder.Entity<Reservation>()
                .HasIndex(r => r.ReservationStatusId)
                .HasDatabaseName("IX_Reservation_StatusId");

            builder.Entity<Room>()
                .HasIndex(r => r.RoomStatusId)
                .HasDatabaseName("IX_Room_StatusId");

            builder.Entity<Invoice>()
                .HasIndex(i => new { i.IsPaid, i.DueDate })
                .HasDatabaseName("IX_Invoice_IsPaid_DueDate");

            builder.Entity<RatePlan>()
                .Property(rp => rp.PriceModifier)
                .HasPrecision(18, 2);

            builder.Entity<RatePlan>()
                .HasIndex(rp => new { rp.StartDate, rp.EndDate, rp.IsActive })
                .HasDatabaseName("IX_RatePlan_DateRange_Active");

            SeedData(builder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var auditEntries = OnBeforeSaveChanges();
            var result = await base.SaveChangesAsync(cancellationToken);
            await OnAfterSaveChanges(auditEntries);
            return result;
        }

        private List<AuditEntry> OnBeforeSaveChanges()
        {
            ChangeTracker.DetectChanges();
            var auditEntries = new List<AuditEntry>();

            var userId = _httpContextAccessor?.HttpContext?.User?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value ?? "System";
            var userName = _httpContextAccessor?.HttpContext?.User?.Identity?.Name ?? "System";

            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is AuditLog || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                    continue;

                var auditEntry = new AuditEntry
                {
                    UserId = userId,
                    UserName = userName,
                    EntityName = entry.Entity.GetType().Name,
                    Action = entry.State.ToString(),
                    Entry = entry
                };

                foreach (var property in entry.Properties)
                {
                    if (property.IsTemporary)
                    {
                        auditEntry.TemporaryProperties.Add(property);
                        continue;
                    }

                    var propertyName = property.Metadata.Name;

                    if (entry.State == EntityState.Added)
                    {
                        auditEntry.NewValues[propertyName] = property.CurrentValue;
                    }
                    else if (entry.State == EntityState.Deleted)
                    {
                        auditEntry.OldValues[propertyName] = property.OriginalValue;
                    }
                    else if (entry.State == EntityState.Modified && property.IsModified)
                    {
                        auditEntry.OldValues[propertyName] = property.OriginalValue;
                        auditEntry.NewValues[propertyName] = property.CurrentValue;
                    }
                }

                if (entry.State == EntityState.Added || entry.State == EntityState.Deleted ||
                    auditEntry.OldValues.Count > 0)
                {
                    auditEntries.Add(auditEntry);
                }
            }

            foreach (var auditEntry in auditEntries.Where(e => !e.HasTemporaryProperties))
            {
                AuditLogs.Add(auditEntry.ToAuditLog());
            }

            return auditEntries.Where(e => e.HasTemporaryProperties).ToList();
        }

        private async Task OnAfterSaveChanges(List<AuditEntry> auditEntries)
        {
            if (auditEntries.Count == 0) return;

            foreach (var auditEntry in auditEntries)
            {
                foreach (var prop in auditEntry.TemporaryProperties)
                {
                    if (prop.Metadata.IsPrimaryKey())
                    {
                        auditEntry.EntityId = prop.CurrentValue?.ToString();
                    }
                    auditEntry.NewValues[prop.Metadata.Name] = prop.CurrentValue;
                }
                AuditLogs.Add(auditEntry.ToAuditLog());
            }

            await base.SaveChangesAsync();
        }

        private class AuditEntry
        {
            public string UserId { get; set; } = string.Empty;
            public string UserName { get; set; } = string.Empty;
            public string Action { get; set; } = string.Empty;
            public string EntityName { get; set; } = string.Empty;
            public string? EntityId { get; set; }
            public EntityEntry Entry { get; set; } = null!;
            public Dictionary<string, object?> OldValues { get; } = new();
            public Dictionary<string, object?> NewValues { get; } = new();
            public List<PropertyEntry> TemporaryProperties { get; } = new();
            public bool HasTemporaryProperties => TemporaryProperties.Count > 0;

            public AuditLog ToAuditLog()
            {
                var primaryKey = Entry.Properties.FirstOrDefault(p => p.Metadata.IsPrimaryKey());
                return new AuditLog
                {
                    UserId = UserId,
                    UserName = UserName,
                    Action = Action,
                    EntityName = EntityName,
                    EntityId = EntityId ?? primaryKey?.CurrentValue?.ToString(),
                    OldValues = OldValues.Count > 0 ? JsonSerializer.Serialize(OldValues) : null,
                    NewValues = NewValues.Count > 0 ? JsonSerializer.Serialize(NewValues) : null,
                    Timestamp = DateTime.UtcNow
                };
            }
        }


        private void SeedData(ModelBuilder modelBuilder)
        {
            // Fixní datum pro deterministické seed data (UTC required by PostgreSQL)
            var seedDate = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc);

            // Fixní ID pro deterministické migrace
            const string adminRoleId = "a1b2c3d4-e5f6-7890-abcd-ef1234567890";
            const string managerRoleId = "b2c3d4e5-f6a7-8901-bcde-f12345678901";
            const string receptionistRoleId = "c3d4e5f6-a7b8-9012-cdef-123456789012";
            const string adminUserId = "d4e5f6a7-b8c9-0123-defa-234567890123";

            var adminRole = new AppRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" };
            var managerRole = new AppRole { Id = managerRoleId, Name = "Manager", NormalizedName = "MANAGER" };
            var receptionistRole = new AppRole { Id = receptionistRoleId, Name = "Receptionist", NormalizedName = "RECEPTIONIST" };

            modelBuilder.Entity<AppRole>().HasData(adminRole, managerRole, receptionistRole);

            // Admin user is seeded at runtime via DbInitializer (password from configuration)

            modelBuilder.Entity<ReservationSource>().HasData(
                new ReservationSource { Id = 1, Name = "Walk-in" },
                new ReservationSource { Id = 2, Name = "Telefon" },
                new ReservationSource { Id = 3, Name = "Web" },
                new ReservationSource { Id = 4, Name = "OTA (Booking.com apod.)" },
                new ReservationSource { Id = 5, Name = "Email" }
            );

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
                new ReservationStatus { Id = 2, Name = "Zrušená" },
                new ReservationStatus { Id = 3, Name = "Čeká na potvrzení" },
                new ReservationStatus { Id = 4, Name = "Ubytován" },
                new ReservationStatus { Id = 5, Name = "Odhlášen" },
                new ReservationStatus { Id = 6, Name = "Nedostavil se" }
            );

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Name = "Jednolůžkový pokoj" },
                new RoomType { Id = 2, Name = "Dvoulůžkový pokoj" },
                new RoomType { Id = 3, Name = "Třílůžkový pokoj" },
                new RoomType { Id = 4, Name = "Rodinný pokoj" }
            );

            modelBuilder.Entity<MealPlan>().HasData(
                new MealPlan { Id = 1, Name = "Bez stravy", Price = 0 },
                new MealPlan { Id = 2, Name = "Snídaně", Price = 200 },
                new MealPlan { Id = 3, Name = "Polopenze", Price = 500 },
                new MealPlan { Id = 4, Name = "Plná penze", Price = 1000 }
            );

            modelBuilder.Entity<Amenity>().HasData(
                new Amenity { Id = 1, Name = "Wi-Fi", Icon = "bi bi-wifi" },
                new Amenity { Id = 2, Name = "Klimatizace", Icon = "bi bi-snow" },
                new Amenity { Id = 3, Name = "TV", Icon = "bi bi-tv" }
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
                new Customer { Id = 1, FirstName = "Jan", LastName = "Novák", DocumentNumber = "+420725912987", PlaceOfBirth = "Praha", DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc), DateOfIssue = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc), DateOfExpiry = new DateTime(2030, 1, 1, 0, 0, 0, DateTimeKind.Utc), PersonalIdentificationNumber = "CZ1234567890", Nationality = "Česká republika", Phone = "+420123456789", Email = "jan.novak@example.com", Address = "Hlavní 123", City = "Praha", PostalCode = "11000", Country = "Česká republika", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Customer { Id = 2, FirstName = "Petr", LastName = "Svoboda", DocumentNumber = "+420725912298", PlaceOfBirth = "Brno", DateOfBirth = new DateTime(1985, 5, 15), DateOfIssue = new DateTime(2019, 6, 10), DateOfExpiry = new DateTime(2029, 6, 10), PersonalIdentificationNumber = "CZ0987654321", Nationality = "Česká republika", Phone = "+420987654321", Email = "petr.svoboda@example.com", Address = "Náměstí 456", City = "Brno", PostalCode = "60200", Country = "Česká republika", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Customer { Id = 3, FirstName = "Marie", LastName = "Černá", DocumentNumber = "+420745912987", PlaceOfBirth = "Ostrava", DateOfBirth = new DateTime(1992, 3, 25), DateOfIssue = new DateTime(2021, 7, 20), DateOfExpiry = new DateTime(2031, 7, 20), PersonalIdentificationNumber = "CZ4567891234", Nationality = "Česká republika", Phone = "+420654789123", Email = "marie.cerna@example.com", Address = "Sokolská 789", City = "Ostrava", PostalCode = "70200", Country = "Česká republika", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Customer { Id = 4, FirstName = "Anna", LastName = "Havlíčková", DocumentNumber = "+420725612987", PlaceOfBirth = "Plzeň", DateOfBirth = new DateTime(1988, 8, 30), DateOfIssue = new DateTime(2022, 4, 15), DateOfExpiry = new DateTime(2032, 4, 15), PersonalIdentificationNumber = "CZ3216549870", Nationality = "Česká republika", Phone = "+420321654987", Email = "anna.havlickova@example.com", Address = "Jasná 321", City = "Plzeň", PostalCode = "30100", Country = "Česká republika", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Customer { Id = 5, FirstName = "Tomáš", LastName = "Procházka", DocumentNumber = "+420725922987", PlaceOfBirth = "Liberec", DateOfBirth = new DateTime(1995, 12, 12), DateOfIssue = new DateTime(2021, 11, 11), DateOfExpiry = new DateTime(2031, 11, 11), PersonalIdentificationNumber = "CZ1597534680", Nationality = "Česká republika", Phone = "+420159753468", Email = "tomas.prochazka@example.com", Address = "Květná 159", City = "Liberec", PostalCode = "46000", Country = "Česká republika", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Customer { Id = 6, FirstName = "Petra", LastName = "Dvořáková", DocumentNumber = "+420725912387", PlaceOfBirth = "Ústí nad Labem", DateOfBirth = new DateTime(1998, 10, 20), DateOfIssue = new DateTime(2020, 8, 15), DateOfExpiry = new DateTime(2030, 8, 15), PersonalIdentificationNumber = "CZ7539518520", Nationality = "Česká republika", Phone = "+420753951852", Email = "petra.dvorakova@example.com", Address = "Lípa 753", City = "Ústí nad Labem", PostalCode = "40000", Country = "Česká republika", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Customer { Id = 7, FirstName = "Jakub", LastName = "Novotný", DocumentNumber = "+420725112987", PlaceOfBirth = "Hradec Králové", DateOfBirth = new DateTime(1987, 4, 5), DateOfIssue = new DateTime(2021, 5, 1), DateOfExpiry = new DateTime(2031, 5, 1), PersonalIdentificationNumber = "CZ8524567890", Nationality = "Česká republika", Phone = "+420852456789", Email = "jakub.novotny@example.com", Address = "Březová 852", City = "Hradec Králové", PostalCode = "50000", Country = "Česká republika", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Customer { Id = 8, FirstName = "Lucie", LastName = "Krejčová", DocumentNumber = "+420025912987", PlaceOfBirth = "Zlín", DateOfBirth = new DateTime(1993, 11, 11), DateOfIssue = new DateTime(2021, 3, 12), DateOfExpiry = new DateTime(2031, 3, 12), PersonalIdentificationNumber = "CZ2589631470", Nationality = "Česká republika", Phone = "+420258963147", Email = "lucie.krejcova@example.com", Address = "Růžová 258", City = "Zlín", PostalCode = "76000", Country = "Česká republika", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Customer { Id = 9, FirstName = "Martin", LastName = "Fiala", DocumentNumber = "+420723912987", PlaceOfBirth = "Karlovy Vary", DateOfBirth = new DateTime(1980, 9, 9), DateOfIssue = new DateTime(2018, 4, 20), DateOfExpiry = new DateTime(2028, 4, 20), PersonalIdentificationNumber = "CZ3692581470", Nationality = "Česká republika", Phone = "+420369258147", Email = "martin.fiala@example.com", Address = "Modrá 369", City = "Karlovy Vary", PostalCode = "36000", Country = "Česká republika", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Customer { Id = 10, FirstName = "Barbora", LastName = "Kovářová", DocumentNumber = "+420225912987", PlaceOfBirth = "Jihlava", DateOfBirth = new DateTime(1991, 6, 15), DateOfIssue = new DateTime(2021, 9, 15), DateOfExpiry = new DateTime(2031, 9, 15), PersonalIdentificationNumber = "CZ7418529630", Nationality = "Česká republika", Phone = "+420741852963", Email = "barbora.kovarova@example.com", Address = "Violetová 741", City = "Jihlava", PostalCode = "58601", Country = "Česká republika", CreatedAt = seedDate, UpdatedAt = seedDate }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, RoomId = 1, CheckIn = new DateTime(2025, 1, 4), CheckOut = new DateTime(2025, 1, 10), TotalPrice = 6600, ReservationStatusId = 1, CustomerId = 1, Adults = 1, Children = 0, MealPlanId = 2, SpecialRequest = "Přistýlka", AdminNote = "Poznámka pro recepci", CreatedAt = seedDate, UpdatedAt = seedDate, CurrencyId = 3 },
                new Reservation { Id = 2, RoomId = 2, CheckIn = new DateTime(2025, 1, 2), CheckOut = new DateTime(2025, 1, 8), TotalPrice = 13500, ReservationStatusId = 1, CustomerId = 2, Adults = 2, Children = 1, MealPlanId = 3, SpecialRequest = "Dětská postýlka", AdminNote = "Poznámka pro recepci", CreatedAt = seedDate, UpdatedAt = seedDate, CurrencyId = 3 },
                new Reservation { Id = 3, RoomId = 3, CheckIn = new DateTime(2025, 1, 1), CheckOut = new DateTime(2025, 1, 12), TotalPrice = 19000, ReservationStatusId = 1, CustomerId = 3, Adults = 3, Children = 2, MealPlanId = 4, SpecialRequest = "Bezlepková dieta", AdminNote = "Poznámka pro recepci", CreatedAt = seedDate, UpdatedAt = seedDate, CurrencyId = 3 }
                );

            // Invoice, InvoiceItem a Payment seed data závisí na admin userovi (seeded at runtime)
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Wellness vstup", Price = 500, IsPerNight = false },
                new Service { Id = 2, Name = "Parkování", Price = 250, IsPerNight = true },
                new Service { Id = 3, Name = "Domácí mazlíček", Price = 300, IsPerNight = true },
                new Service { Id = 4, Name = "Služba žehlení", Price = 150, IsPerNight = false }
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


            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, CustomerId = 1, RoomId = 1, Rating = 5, Comment = "Skvělý pobyt, čistota na jedničku!", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Review { Id = 2, CustomerId = 2, RoomId = 2, Rating = 4, Comment = "Příjemný personál a dobré jídlo.", CreatedAt = seedDate, UpdatedAt = seedDate },
                new Review { Id = 3, CustomerId = 3, RoomId = 3, Rating = 3, Comment = "Hezký pokoj, ale trochu hlučný soused.", CreatedAt = seedDate, UpdatedAt = seedDate }
            );







        }
    }
}
