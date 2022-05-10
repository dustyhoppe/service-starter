using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PlaylistManager.Domain.Inf
{
    public interface IPackage
    {
        void Register(IServiceCollection services, IConfiguration configuration);
    }
}
