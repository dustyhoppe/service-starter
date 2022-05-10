using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlaylistManager.Domain.Clock;
using PlaylistManager.Domain.Inf;

namespace PlaylistManager.Domain
{
    public class DomainPackage : IPackage
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ISystemClock, SystemClock>();
        }
    }
}
