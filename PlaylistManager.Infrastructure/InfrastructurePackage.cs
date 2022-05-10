using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlaylistManager.Domain.Inf;
using System;

namespace PlaylistManager.Infrastructure
{
    public class InfrastructurePackage : IPackage
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            
        }
    }
}
