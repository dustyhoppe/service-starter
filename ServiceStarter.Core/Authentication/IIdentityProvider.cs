using ServiceStarter.Core.Authorization;
using System.Security.Principal;

namespace ServiceStarter.Core.Authentication
{
    public interface IIdentityProvider
    {
        int GetUserId(IIdentity identity);
        bool HasPolicy(IIdentity identity, string policy);
        bool HasRole(IIdentity identity, RoleType role);
    }
}
