using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Homework2.Api.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project

    //A custom middleware to check client's app version is suitable for server's app version.
    public class AppVersionControlMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public AppVersionControlMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
                var appVersion = _configuration["appVersion"];
                var clientVers = httpContext.Request.Headers["appVersion"].ToString();

                bool versionCheck = CheckClientVersionIsNewer(appVersion, clientVers);

                //true means clients version is newer. Then returns 401
                if (versionCheck)
                {
                    httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                }
                else
                {
                    await _next(httpContext);
                }
        }
        //this method compares two version. If client's version is newer it returns true
        public bool CheckClientVersionIsNewer (string appVersion, string clientVersion)
        {
            try
            {
                double app = Convert.ToDouble(appVersion);
                double client = Convert.ToDouble(clientVersion);

                if (client > app)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
    
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseAppVersionControlMiddleware(this IApplicationBuilder builder, string version)
        {
            return builder.UseMiddleware<AppVersionControlMiddleware>();
        }
    }
}
