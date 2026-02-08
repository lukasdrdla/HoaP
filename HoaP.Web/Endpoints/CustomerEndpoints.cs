using HoaP.Application.Services;
using HoaP.Application.ViewModels.Customer;

namespace HoaP.Web.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void MapCustomerEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/api/customers").RequireAuthorization();

            group.MapGet("/", async (CustomerService service) =>
            {
                var customers = await service.GetCustomersAsync();
                return Results.Ok(customers);
            });

            group.MapGet("/{id:int}", async (int id, CustomerService service) =>
            {
                var customer = await service.GetCustomerById(id);
                if (customer is null)
                    return Results.NotFound();

                return Results.Ok(customer);
            });

            group.MapPost("/", async (CustomerFormViewModel model, CustomerService service) =>
            {
                try
                {
                    await service.CreateCustomer(model);
                    return Results.Created();
                }
                catch (InvalidOperationException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapPut("/{id:int}", async (int id, CustomerFormViewModel model, CustomerService service) =>
            {
                try
                {
                    model.Id = id;
                    await service.UpdateCustomer(model);
                    return Results.NoContent();
                }
                catch (InvalidOperationException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapDelete("/{id:int}", async (int id, CustomerService service) =>
            {
                try
                {
                    await service.DeleteCustomer(id);
                    return Results.NoContent();
                }
                catch (InvalidOperationException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });
        }
    }
}
