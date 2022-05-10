using System.Security.Principal;

namespace PlaylistManager.Core.Authorization
{
    public interface IAuthorized
    {
        IIdentity Identity { get; }
        string RequiredPolicy { get; }
    }
}

