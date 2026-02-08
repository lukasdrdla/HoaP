using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HoaP.Infrastructure.Services
{
    public class TenantService : ITenantService
    {
        private readonly MasterDbContext _masterDb;
        private readonly IConfiguration _configuration;

        public TenantService(MasterDbContext masterDb, IConfiguration configuration)
        {
            _masterDb = masterDb;
            _configuration = configuration;
        }

        public Tenant? CurrentTenant { get; set; }

        public async Task<Tenant?> GetTenantBySubdomainAsync(string subdomain)
        {
            return await _masterDb.Tenants
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Subdomain == subdomain && t.IsActive);
        }

        public async Task<List<Tenant>> GetAllTenantsAsync()
        {
            return await _masterDb.Tenants
                .AsNoTracking()
                .OrderBy(t => t.Name)
                .ToListAsync();
        }

        public async Task<Tenant> CreateTenantAsync(string name, string subdomain)
        {
            var existing = await _masterDb.Tenants.AnyAsync(t => t.Subdomain == subdomain);
            if (existing)
                throw new InvalidOperationException($"Subdoména '{subdomain}' je již obsazená.");

            var dbName = $"hoap_tenant_{subdomain.ToLowerInvariant()}";
            var baseConnectionString = _configuration.GetConnectionString("DefaultConnection")!;

            // Replace database name in connection string
            var tenantConnectionString = ReplaceDatabase(baseConnectionString, dbName);

            var tenant = new Tenant
            {
                Id = Guid.NewGuid(),
                Name = name,
                Subdomain = subdomain.ToLowerInvariant(),
                DatabaseName = dbName,
                ConnectionString = tenantConnectionString,
                IsActive = true,
                Plan = "basic",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            await _masterDb.Tenants.AddAsync(tenant);
            await _masterDb.SaveChangesAsync();

            return tenant;
        }

        public async Task UpdateTenantAsync(Tenant tenant)
        {
            var existing = await _masterDb.Tenants.FindAsync(tenant.Id)
                ?? throw new InvalidOperationException("Tenant nenalezen.");

            existing.Name = tenant.Name;
            existing.IsActive = tenant.IsActive;
            existing.Plan = tenant.Plan;
            existing.CustomDomain = tenant.CustomDomain;
            existing.TrialExpiresAt = tenant.TrialExpiresAt;
            existing.UpdatedAt = DateTime.Now;

            await _masterDb.SaveChangesAsync();
        }

        public async Task DeactivateTenantAsync(Guid tenantId)
        {
            var tenant = await _masterDb.Tenants.FindAsync(tenantId)
                ?? throw new InvalidOperationException("Tenant nenalezen.");

            tenant.IsActive = false;
            tenant.UpdatedAt = DateTime.Now;
            await _masterDb.SaveChangesAsync();
        }

        private static string ReplaceDatabase(string connectionString, string newDatabase)
        {
            var parts = connectionString.Split(';')
                .Select(p =>
                {
                    var kv = p.Split('=', 2);
                    if (kv.Length == 2 && kv[0].Trim().Equals("database", StringComparison.OrdinalIgnoreCase))
                        return $"database={newDatabase}";
                    return p;
                });
            return string.Join(";", parts);
        }
    }
}
