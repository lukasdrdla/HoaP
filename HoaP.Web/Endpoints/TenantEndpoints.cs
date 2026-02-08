using HoaP.Application.Interfaces;

namespace HoaP.Web.Endpoints
{
    public static class TenantEndpoints
    {
        public static void MapTenantEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/api/tenants").RequireAuthorization();

            group.MapGet("/", async (ITenantService tenantService) =>
            {
                var tenants = await tenantService.GetAllTenantsAsync();
                return Results.Ok(tenants.Select(t => new
                {
                    t.Id,
                    t.Name,
                    t.Subdomain,
                    t.IsActive,
                    t.Plan,
                    t.CreatedAt
                }));
            });

            group.MapPost("/", async (CreateTenantRequest request, ITenantService tenantService) =>
            {
                try
                {
                    var tenant = await tenantService.CreateTenantAsync(request.Name, request.Subdomain);
                    return Results.Created($"/api/tenants/{tenant.Id}", new { tenant.Id, tenant.Name, tenant.Subdomain });
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapDelete("/{id:guid}", async (Guid id, ITenantService tenantService) =>
            {
                try
                {
                    await tenantService.DeactivateTenantAsync(id);
                    return Results.Ok();
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });
        }

        private record CreateTenantRequest(string Name, string Subdomain);
    }
}
