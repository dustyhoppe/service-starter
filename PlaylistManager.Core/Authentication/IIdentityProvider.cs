using PlaylistManager.Core.Authorization;
using System.Security.Principal;

namespace PlaylistManager.Core.Authentication
{
    public interface IIdentityProvider
    {
        int GetUserId(IIdentity identity);
        bool HasPolicy(IIdentity identity, string policy);
        bool HasRole(IIdentity identity, RoleType role);
    }
}
