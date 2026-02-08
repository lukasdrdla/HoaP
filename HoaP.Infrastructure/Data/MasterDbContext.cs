using HoaP.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Data
{
    public class MasterDbContext : DbContext
    {
        public MasterDbContext(DbContextOptions<MasterDbContext> options) : base(options) { }

        public DbSet<Tenant> Tenants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Tenant>()
                .HasIndex(t => t.Subdomain)
                .IsUnique()
                .HasDatabaseName("IX_Tenant_Subdomain");

            builder.Entity<Tenant>()
                .Property(t => t.Name)
                .HasMaxLength(200);

            builder.Entity<Tenant>()
                .Property(t => t.Subdomain)
                .HasMaxLength(100);

            builder.Entity<Tenant>()
                .Property(t => t.ConnectionString)
                .HasMaxLength(500);

            builder.Entity<Tenant>()
                .Property(t => t.DatabaseName)
                .HasMaxLength(200);

            builder.Entity<Tenant>()
                .Property(t => t.Plan)
                .HasMaxLength(50);
        }
    }
}
