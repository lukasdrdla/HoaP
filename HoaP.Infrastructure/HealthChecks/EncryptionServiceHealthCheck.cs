using Microsoft.Extensions.Diagnostics.HealthChecks;
using HoaP.Application.Interfaces;

namespace HoaP.Infrastructure.HealthChecks
{
    public class EncryptionServiceHealthCheck : IHealthCheck
    {
        private readonly IEncryptionService _encryptionService;

        public EncryptionServiceHealthCheck(IEncryptionService encryptionService)
        {
            _encryptionService = encryptionService;
        }

        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                var testValue = "health-check-test";
                var encrypted = _encryptionService.Encrypt(testValue);
                var decrypted = _encryptionService.Decrypt(encrypted);

                if (decrypted == testValue)
                    return Task.FromResult(HealthCheckResult.Healthy("Šifrovací služba funguje správně."));

                return Task.FromResult(HealthCheckResult.Unhealthy("Šifrování/dešifrování neproběhlo správně."));
            }
            catch (Exception ex)
            {
                return Task.FromResult(HealthCheckResult.Unhealthy("Chyba šifrovací služby.", ex));
            }
        }
    }
}
