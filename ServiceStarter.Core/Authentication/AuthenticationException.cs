using System;

namespace ServiceStarter.Core.Authentication
{
    public class AuthenticationException : Exception
    {
        public AuthenticationException()
            : base("You must be logged in to perform this action.")
        { }
    }
}
