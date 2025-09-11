using Microsoft.Extensions.Options;
using Sonali.API.Utilities;
using Sonali.API.Utilities.FileManagement;

namespace Sonali.API.Middlewares
{
    public class FileValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly FileUploadSettings _settings;

        public FileValidationMiddleware(RequestDelegate next, IOptions<FileUploadSettings> settings)
        {
            _next = next;
            _settings = settings.Value;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Post &&
                context.Request.HasFormContentType &&
                context.Request.Form.Files.Count > 0)
            {
                foreach (var file in context.Request.Form.Files)
                {
                    //Size check
                    var fileSizeMB = file.Length / (1024.0 * 1024.0);
                    if (fileSizeMB > _settings.MaxFileSizeMB)
                    {
                        context.Response.StatusCode = StatusCodes.Status400BadRequest;
                        await context.Response.WriteAsync(
                            $"File '{file.FileName}' exceeds the allowed size of {_settings.MaxFileSizeMB} MB.");
                        return; // stop pipeline
                        //throw new FileValidationException($"File '{file.FileName}' exceeds the allowed size of {_settings.MaxFileSizeMB} MB.");
                    }

                    //Extension check
                    var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
                    if (!_settings.AllowedExtensions.Contains(ext))
                    {
                        context.Response.StatusCode = StatusCodes.Status400BadRequest;
                        await context.Response.WriteAsync(
                            $"File '{file.FileName}' has invalid extension. Allowed: {string.Join(", ", _settings.AllowedExtensions)}");
                        return;
                        //throw new FileValidationException($"File '{file.FileName}' has invalid extension. Allowed: {string.Join(", ", _settings.AllowedExtensions)}");
                    }
                }
            }

            await _next(context);
        }
    }

}
