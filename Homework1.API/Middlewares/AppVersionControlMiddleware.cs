using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Homework1.API.Middlewares
{
    public class AppVersionControlMiddleware : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new System.NotImplementedException();
        }
    }
}
