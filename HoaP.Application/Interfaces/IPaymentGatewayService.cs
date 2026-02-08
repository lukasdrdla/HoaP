using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IPaymentGatewayService
    {
        Task<PaymentSession> InitiatePaymentAsync(decimal amount, string currencyCode, string returnUrl, string description);
        Task<PaymentGatewayResult> VerifyPaymentAsync(string sessionId);
        Task<RefundResult> RefundPaymentAsync(string transactionId, decimal amount);
    }
}
