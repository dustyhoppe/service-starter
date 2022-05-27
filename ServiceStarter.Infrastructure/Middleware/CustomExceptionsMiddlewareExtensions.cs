using Microsoft.AspNetCore.Builder;

namespace ServiceStarter.Infrastructure.Middleware
{
    public static class CustomExceptionsMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptions(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionsMiddleware>();
        }
    }
}
