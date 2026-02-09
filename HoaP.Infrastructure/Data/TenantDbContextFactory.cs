using HoaP.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HoaP.Infrastructure.Data
{
    public class TenantDbContextFactory
    {
        private readonly ITenantService _tenantService;
        private readonly IEncryptionService? _encryptionService;
        private readonly IHttpContextAccessor? _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public TenantDbContextFactory(
            ITenantService tenantService,
            IConfiguration configuration,
            IEncryptionService? encryptionService = null,
            IHttpContextAccessor? httpContextAccessor = null)
        {
            _tenantService = tenantService;
            _configuration = configuration;
            _encryptionService = encryptionService;
            _httpContextAccessor = httpContextAccessor;
        }

        public ApplicationDbContext CreateDbContext()
        {
            string connectionString;

            if (_tenantService.CurrentTenant != null)
            {
                connectionString = _tenantService.CurrentTenant.ConnectionString;
            }
            else
            {
                // Fallback to default connection (single-tenant mode)
                connectionString = _configuration.GetConnectionString("DefaultConnection")
                    ?? throw new InvalidOperationException("No tenant context and no default connection string.");
            }

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options, _encryptionService, _httpContextAccessor);
        }
    }
}
