using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStarter.Core.Authorization;
using ServiceStarter.Core.Validation;
using ServiceStarter.Domain.Inf;

namespace ServiceStarter.Core
{
    public class CorePackage : IPackage
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(GetType().Assembly);
            services.AddMediatR(GetType().Assembly);
            services.AddValidatorsFromAssembly(GetType().Assembly);
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}
