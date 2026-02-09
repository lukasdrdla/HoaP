using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace HoaP.Infrastructure.Middleware
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;
        private readonly IHostEnvironment _environment;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger, IHostEnvironment environment)
        {
            _next = next;
            _logger = logger;
            _environment = environment;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var isApiRequest = context.Request.Path.StartsWithSegments("/api");

                if (!isApiRequest)
                {
                    _logger.LogError(ex, "Neošetřená chyba na {Path}", context.Request.Path);
                    throw;
                }

                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            _logger.LogError(exception, "API chyba na {Method} {Path}", context.Request.Method, context.Request.Path);

            var (statusCode, title) = exception switch
            {
                InvalidOperationException => (StatusCodes.Status400BadRequest, "Neplatná operace"),
                KeyNotFoundException => (StatusCodes.Status404NotFound, "Záznam nenalezen"),
                UnauthorizedAccessException => (StatusCodes.Status403Forbidden, "Přístup zamítnut"),
                _ => (StatusCodes.Status500InternalServerError, "Interní chyba serveru")
            };

            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/problem+json";

            var problemDetails = new
            {
                type = $"https://httpstatuses.com/{statusCode}",
                title,
                status = statusCode,
                detail = _environment.IsDevelopment() ? exception.Message : GetSafeMessage(statusCode),
                instance = context.Request.Path.Value,
                traceId = context.TraceIdentifier
            };

            var json = JsonSerializer.Serialize(problemDetails, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            await context.Response.WriteAsync(json);
        }

        private static string GetSafeMessage(int statusCode) => statusCode switch
        {
            400 => "Požadavek obsahuje neplatná data.",
            404 => "Požadovaný záznam nebyl nalezen.",
            403 => "K této operaci nemáte oprávnění.",
            _ => "Došlo k neočekávané chybě. Zkuste to prosím znovu."
        };
    }
}
