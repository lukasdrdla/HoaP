using HoaP.Infrastructure.Services;

namespace HoaP.Tests.Services
{
    public class MockPaymentGatewayServiceTests
    {
        private readonly MockPaymentGatewayService _service;

        public MockPaymentGatewayServiceTests()
        {
            _service = new MockPaymentGatewayService();
        }

        [Fact]
        public async Task InitiatePayment_CreatesSession()
        {
            var session = await _service.InitiatePaymentAsync(1000, "CZK", "/return", "Test");

            Assert.NotNull(session);
            Assert.NotEmpty(session.SessionId);
            Assert.Equal(1000, session.Amount);
            Assert.Equal("CZK", session.CurrencyCode);
            Assert.Equal("pending", session.Status);
            Assert.Contains("/payment/mock/", session.PaymentUrl);
        }

        [Fact]
        public async Task VerifyPayment_BeforeCompletion_ReturnsPending()
        {
            var session = await _service.InitiatePaymentAsync(1000, "CZK", "/return", "Test");
            var result = await _service.VerifyPaymentAsync(session.SessionId);

            Assert.False(result.Success);
            Assert.Equal("pending", result.Status);
        }

        [Fact]
        public async Task VerifyPayment_AfterCompletion_ReturnsSuccess()
        {
            var session = await _service.InitiatePaymentAsync(1000, "CZK", "/return", "Test");
            _service.CompletePayment(session.SessionId);

            var result = await _service.VerifyPaymentAsync(session.SessionId);

            Assert.True(result.Success);
            Assert.Equal("completed", result.Status);
            Assert.StartsWith("MOCK-TXN-", result.TransactionId);
        }

        [Fact]
        public async Task VerifyPayment_InvalidSession_ReturnsNotFound()
        {
            var result = await _service.VerifyPaymentAsync("nonexistent");

            Assert.False(result.Success);
            Assert.Equal("not_found", result.Status);
        }

        [Fact]
        public async Task RefundPayment_ReturnsSuccess()
        {
            var result = await _service.RefundPaymentAsync("MOCK-TXN-12345678", 500);

            Assert.True(result.Success);
            Assert.Equal(500, result.RefundedAmount);
            Assert.StartsWith("MOCK-REF-", result.RefundId);
        }

        [Fact]
        public void GetSession_ReturnsStoredSession()
        {
            var session = _service.InitiatePaymentAsync(2000, "EUR", "/callback", "Desc").Result;
            var retrieved = _service.GetSession(session.SessionId);

            Assert.NotNull(retrieved);
            Assert.Equal(2000, retrieved.Amount);
            Assert.Equal("EUR", retrieved.CurrencyCode);
        }

        [Fact]
        public void CancelPayment_SetsStatusToFailed()
        {
            var session = _service.InitiatePaymentAsync(1000, "CZK", "/return", "Test").Result;
            var canceled = _service.CancelPayment(session.SessionId);

            Assert.True(canceled);
            var retrieved = _service.GetSession(session.SessionId);
            Assert.Equal("failed", retrieved!.Status);
        }
    }
}
