using System.Security.Principal;

namespace ServiceStarter.Core.Authorization
{
    public interface IAuthorized
    {
        IIdentity Identity { get; }
        string RequiredPolicy { get; }
    }
}

