using HoaP.Application.Interfaces;

namespace HoaP.Web.Endpoints
{
    public static class PaymentGatewayEndpoints
    {
        public static void MapPaymentGatewayEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/api/payment");

            group.MapPost("/initiate", async (PaymentInitiateRequest request, IPaymentGatewayService gateway) =>
            {
                var session = await gateway.InitiatePaymentAsync(
                    request.Amount, request.CurrencyCode, request.ReturnUrl, request.Description);
                return Results.Ok(session);
            }).RequireAuthorization();

            group.MapGet("/verify/{sessionId}", async (string sessionId, IPaymentGatewayService gateway) =>
            {
                var result = await gateway.VerifyPaymentAsync(sessionId);
                return Results.Ok(result);
            });

            group.MapPost("/refund", async (RefundRequest request, IPaymentGatewayService gateway) =>
            {
                var result = await gateway.RefundPaymentAsync(request.TransactionId, request.Amount);
                return Results.Ok(result);
            }).RequireAuthorization();

            group.MapPost("/webhook", (HttpContext context) =>
            {
                // Placeholder for real payment gateway webhooks
                return Results.Ok(new { received = true });
            });
        }

        private record PaymentInitiateRequest(decimal Amount, string CurrencyCode, string ReturnUrl, string Description);
        private record RefundRequest(string TransactionId, decimal Amount);
    }
}
