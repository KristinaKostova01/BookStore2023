using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BookStore.HealtCheck
{
    public class CustomHealtCheck : IHealthCheck
    {
        public Task<HealthCheckResult>CheckHealthAsync(HealthCheckContext context,
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
    var isHealty = true;

    if(isHealthy)
        {
        return Task.FromResult(
                  HealthCheckResult.Healty(description:))
}
