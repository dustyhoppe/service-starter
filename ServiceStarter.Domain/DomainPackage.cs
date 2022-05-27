using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStarter.Domain.Clock;
using ServiceStarter.Domain.Inf;

namespace ServiceStarter.Domain
{
    public class DomainPackage : IPackage
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ISystemClock, SystemClock>();
        }
    }
}
