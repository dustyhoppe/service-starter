using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlaylistManager.Core.Authorization;
using PlaylistManager.Core.Validation;
using PlaylistManager.Domain.Inf;

namespace PlaylistManager.Core
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
