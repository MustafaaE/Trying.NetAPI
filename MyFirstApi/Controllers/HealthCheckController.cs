using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MyFirstApi.Controllers

{
    public class HealthCheckController : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealthy = false;

            if (isHealthy)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("A healthy result."));
            }
            return Task.FromResult(
                new HealthCheckResult(
                    context.Registration.FailureStatus, "An unhealthy result."));
            //throw new NotImplementedException();
        }
    }
}
