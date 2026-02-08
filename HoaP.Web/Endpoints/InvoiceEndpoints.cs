using HoaP.Application.Services;
using HoaP.Application.ViewModels.Invoice;

namespace HoaP.Web.Endpoints
{
    public static class InvoiceEndpoints
    {
        public static void MapInvoiceEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/api/invoices").RequireAuthorization();

            group.MapGet("/", async (InvoiceService service) =>
            {
                var invoices = await service.GetInvoicesAsync();
                return Results.Ok(invoices);
            });

            group.MapGet("/{id:int}", async (int id, InvoiceService service) =>
            {
                var invoice = await service.GetInvoiceByIdAsync(id);
                if (invoice is null)
                    return Results.NotFound();

                return Results.Ok(invoice);
            });

            group.MapPost("/", async (InvoiceFormViewModel model, InvoiceService service) =>
            {
                try
                {
                    await service.CreateInvoiceAsync(model);
                    return Results.Created();
                }
                catch (InvalidOperationException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapPut("/{id:int}", async (int id, InvoiceFormViewModel model, InvoiceService service) =>
            {
                try
                {
                    model.Id = id;
                    await service.UpdateInvoiceAsync(model);
                    return Results.NoContent();
                }
                catch (InvalidOperationException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapDelete("/{id:int}", async (int id, InvoiceService service) =>
            {
                try
                {
                    await service.DeleteInvoiceAsync(id);
                    return Results.NoContent();
                }
                catch (InvalidOperationException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapGet("/{id:int}/pdf", async (int id, InvoiceService invoiceService,
                HotelProfileService hotelProfileService, InvoicePdfGenerator pdfGenerator) =>
            {
                var invoice = await invoiceService.GetInvoiceByIdAsync(id);
                if (invoice is null)
                    return Results.NotFound();

                var hotel = await hotelProfileService.GetHotelProfileAsync();
                var pdfBytes = pdfGenerator.GeneratePdf(invoice, hotel);

                return Results.File(pdfBytes, "application/pdf", $"invoice-{invoice.InvoiceNumber}.pdf");
            });
        }
    }
}
