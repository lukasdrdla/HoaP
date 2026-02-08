using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HoaP.Infrastructure.HealthChecks
{
    public class DiskSpaceHealthCheck : IHealthCheck
    {
        private readonly long _minimumFreeMegabytes;

        public DiskSpaceHealthCheck(long minimumFreeMegabytes = 500)
        {
            _minimumFreeMegabytes = minimumFreeMegabytes;
        }

        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                var drive = new DriveInfo(Path.GetPathRoot(AppContext.BaseDirectory) ?? "C");
                var freeSpaceMb = drive.AvailableFreeSpace / (1024 * 1024);

                if (freeSpaceMb >= _minimumFreeMegabytes)
                    return Task.FromResult(HealthCheckResult.Healthy(
                        $"Dostatek místa na disku: {freeSpaceMb} MB volných."));

                if (freeSpaceMb >= _minimumFreeMegabytes / 2)
                    return Task.FromResult(HealthCheckResult.Degraded(
                        $"Málo místa na disku: {freeSpaceMb} MB volných."));

                return Task.FromResult(HealthCheckResult.Unhealthy(
                    $"Kriticky málo místa na disku: {freeSpaceMb} MB volných."));
            }
            catch (Exception ex)
            {
                return Task.FromResult(HealthCheckResult.Unhealthy("Nelze zkontrolovat místo na disku.", ex));
            }
        }
    }
}
