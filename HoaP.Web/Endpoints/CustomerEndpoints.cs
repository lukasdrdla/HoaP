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
                return customer is null ? Results.NotFound() : Results.Ok(customer);
            });

            group.MapPost("/", async (CustomerFormViewModel model, CustomerService service) =>
            {
                await service.CreateCustomer(model);
                return Results.Created();
            });

            group.MapPut("/{id:int}", async (int id, CustomerFormViewModel model, CustomerService service) =>
            {
                model.Id = id;
                await service.UpdateCustomer(model);
                return Results.NoContent();
            });

            group.MapDelete("/{id:int}", async (int id, CustomerService service) =>
            {
                await service.DeleteCustomer(id);
                return Results.NoContent();
            });
        }
    }
}
