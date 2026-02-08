namespace HoaP.Domain.Entities
{
    public class PaymentSession
    {
        public string SessionId { get; set; } = string.Empty;
        public string PaymentUrl { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ReturnUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime ExpiresAt { get; set; }
        public string Status { get; set; } = "pending";
    }
}
