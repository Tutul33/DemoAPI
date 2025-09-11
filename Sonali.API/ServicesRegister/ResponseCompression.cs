using Microsoft.AspNetCore.ResponseCompression;
using System.IO.Compression;

namespace Sonali.API.ServicesRegister
{
    public static class ResponseCompression
    {
        public static void Register(WebApplicationBuilder builder)
        {
            builder.Services.AddResponseCompression(options =>
            {
                // Enable compression for HTTPS responses
                options.EnableForHttps = true;

                // Add MIME types you want compressed
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                {
                  "application/json",
                  "application/xml",
                  "text/plain",
                  "text/csv"
                });
            });

            builder.Services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Fastest; // or Optimal (slower, better compression)
            });
            builder.Services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
            });
        }
    }
}
