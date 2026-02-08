using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface ITenantService
    {
        Tenant? CurrentTenant { get; set; }
        Task<Tenant?> GetTenantBySubdomainAsync(string subdomain);
        Task<List<Tenant>> GetAllTenantsAsync();
        Task<Tenant> CreateTenantAsync(string name, string subdomain);
        Task UpdateTenantAsync(Tenant tenant);
        Task DeactivateTenantAsync(Guid tenantId);
    }
}
