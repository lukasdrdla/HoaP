namespace HoaP.Domain.Entities
{
    public class Tenant : AuditableEntity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string Subdomain { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public string? CustomDomain { get; set; }
        public string Plan { get; set; } = "basic";
        public DateTime? TrialExpiresAt { get; set; }
    }
}
