using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStarter.Domain.Inf;
using System;

namespace ServiceStarter.Infrastructure
{
    public class InfrastructurePackage : IPackage
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            
        }
    }
}
