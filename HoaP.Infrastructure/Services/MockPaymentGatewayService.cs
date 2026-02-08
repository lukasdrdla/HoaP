using System.Collections.Concurrent;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;

namespace HoaP.Infrastructure.Services
{
    public class MockPaymentGatewayService : IPaymentGatewayService
    {
        private static readonly ConcurrentDictionary<string, PaymentSession> _sessions = new();

        public Task<PaymentSession> InitiatePaymentAsync(
            decimal amount, string currencyCode, string returnUrl, string description)
        {
            var sessionId = Guid.NewGuid().ToString("N");
            var session = new PaymentSession
            {
                SessionId = sessionId,
                PaymentUrl = $"/payment/mock/{sessionId}",
                Amount = amount,
                CurrencyCode = currencyCode,
                Description = description,
                ReturnUrl = returnUrl,
                ExpiresAt = DateTime.UtcNow.AddMinutes(30),
                Status = "pending"
            };
            _sessions[sessionId] = session;
            return Task.FromResult(session);
        }

        public Task<PaymentGatewayResult> VerifyPaymentAsync(string sessionId)
        {
            if (_sessions.TryGetValue(sessionId, out var session))
            {
                return Task.FromResult(new PaymentGatewayResult
                {
                    Success = session.Status == "completed",
                    TransactionId = $"MOCK-TXN-{sessionId[..8].ToUpper()}",
                    Status = session.Status,
                    ProcessedAt = DateTime.UtcNow
                });
            }
            return Task.FromResult(new PaymentGatewayResult
            {
                Success = false,
                Status = "not_found",
                ErrorMessage = "Platební relace nebyla nalezena."
            });
        }

        public Task<RefundResult> RefundPaymentAsync(string transactionId, decimal amount)
        {
            return Task.FromResult(new RefundResult
            {
                Success = true,
                RefundId = $"MOCK-REF-{Guid.NewGuid().ToString("N")[..8].ToUpper()}",
                RefundedAmount = amount
            });
        }

        public PaymentSession? GetSession(string sessionId)
        {
            _sessions.TryGetValue(sessionId, out var session);
            return session;
        }

        public bool CompletePayment(string sessionId)
        {
            if (_sessions.TryGetValue(sessionId, out var session))
            {
                session.Status = "completed";
                return true;
            }
            return false;
        }

        public bool CancelPayment(string sessionId)
        {
            if (_sessions.TryGetValue(sessionId, out var session))
            {
                session.Status = "failed";
                return true;
            }
            return false;
        }
    }
}
