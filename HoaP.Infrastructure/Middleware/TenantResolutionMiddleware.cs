using HoaP.Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace HoaP.Infrastructure.Middleware
{
    public class TenantResolutionMiddleware
    {
        private readonly RequestDelegate _next;

        public TenantResolutionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ITenantService tenantService)
        {
            var subdomain = ResolveSubdomain(context);

            if (!string.IsNullOrEmpty(subdomain))
            {
                var tenant = await tenantService.GetTenantBySubdomainAsync(subdomain);
                if (tenant != null)
                {
                    tenantService.CurrentTenant = tenant;
                }
            }

            // If no tenant resolved, the system falls back to DefaultConnection (single-tenant mode)
            await _next(context);
        }

        private static string? ResolveSubdomain(HttpContext context)
        {
            // Strategy 1: X-Tenant-Id header (for API clients)
            var headerTenant = context.Request.Headers["X-Tenant-Id"].FirstOrDefault();
            if (!string.IsNullOrEmpty(headerTenant))
                return headerTenant;

            // Strategy 2: Subdomain from Host
            var host = context.Request.Host.Host;
            var parts = host.Split('.');

            // Needs at least 3 parts: subdomain.domain.tld
            if (parts.Length >= 3)
            {
                var subdomain = parts[0];
                // Skip common non-tenant subdomains
                if (subdomain != "www" && subdomain != "api" && subdomain != "admin")
                    return subdomain;
            }

            return null;
        }
    }
}
