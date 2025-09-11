using Sonali.API.Utilities;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net;

namespace Sonali.API.Middlewares
{
    public class ApiResponseMiddleware
    {
        private readonly RequestDelegate _next;

        public ApiResponseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Skip wrapping for static files (like images, css, js)
                if (context.Request.Path.StartsWithSegments("/uploads") || //For Uploads, it must be skipped
                    context.Request.Path.StartsWithSegments("/swagger") || //For swagger, it must be skipped
                    context.Request.Path.StartsWithSegments("/chathub") || //For SignalR, it must be skipped
                    Path.HasExtension(context.Request.Path))
                {
                    await _next(context);
                    return;
                }

                // Capture the response body
                var originalBodyStream = context.Response.Body;

                using var responseBody = new MemoryStream();
                context.Response.Body = responseBody;

                await _next(context);

                // Read response body
                context.Response.Body.Seek(0, SeekOrigin.Begin);
                var bodyText = await new StreamReader(context.Response.Body).ReadToEndAsync();
                context.Response.Body.Seek(0, SeekOrigin.Begin);

                // Wrap response using ApiResponse
                object? result;
                if (context.Response.StatusCode >= 400)
                {
                    result = ApiResponse<object>.ErrorResponse(
                        message: !string.IsNullOrEmpty(bodyText) ? bodyText : "An error occurred"
                    );
                }
                else
                {
                    object? data = null;
                    if (!string.IsNullOrWhiteSpace(bodyText))
                    {
                        try
                        {
                            data = JsonConvert.DeserializeObject<object>(bodyText);
                        }
                        catch
                        {
                            data = bodyText; // fallback to raw string
                        }
                    }

                    result = ApiResponse<object>.SuccessResponse(data);
                }

                // Write the wrapped response
                context.Response.ContentType = "application/json";
                context.Response.Body = originalBodyStream;

                var json = JsonConvert.SerializeObject(result, new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                });

                await context.Response.WriteAsync(json);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var errorResponse = ApiResponse<object>.ErrorResponse(
                    message: ex.Message,
                    errors: new List<string> { ex.StackTrace ?? string.Empty }
                );

                var json = JsonConvert.SerializeObject(errorResponse, new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                });

                await context.Response.WriteAsync(json);
            }
        }
    }
}
