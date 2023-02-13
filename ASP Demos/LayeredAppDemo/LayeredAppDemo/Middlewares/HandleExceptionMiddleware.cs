using LayeredAppDemo.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LayeredAppDemo.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HandleExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public HandleExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                await HandleException(httpContext, e);
            }
        }
        async Task HandleException(HttpContext context, Exception exception)
        {
            var response = context.Response;
            var message = exception.Message;
            
            response.ContentType = "application/json";
            await response.WriteAsync(message);
        }

    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HandleExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseHandleExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HandleExceptionMiddleware>();
        }
    }
}
