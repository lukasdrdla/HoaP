namespace HoaP.Domain.Entities
{
    public class PaymentGatewayResult
    {
        public bool Success { get; set; }
        public string TransactionId { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string? ErrorMessage { get; set; }
        public DateTime ProcessedAt { get; set; } = DateTime.UtcNow;
    }

    public class RefundResult
    {
        public bool Success { get; set; }
        public string RefundId { get; set; } = string.Empty;
        public decimal RefundedAmount { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
