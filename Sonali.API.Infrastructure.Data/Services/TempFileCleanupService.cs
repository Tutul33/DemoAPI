using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Sonali.API.Infrastructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Infrastructure.Data.Services
{
    public class TempFileCleanupService : BackgroundService
    {
        private readonly ILogger<TempFileCleanupService> _logger;
        private readonly TempFileCleanupSettings _settings;

        public TempFileCleanupService(
            ILogger<TempFileCleanupService> logger,
            IOptions<TempFileCleanupSettings> options)
        {
            _logger = logger;
            _settings = options.Value;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("TempFileCleanupService started.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    foreach (var folder in _settings.Folders)
                    {
                        if (!Directory.Exists(folder))
                            continue;

                        var files = Directory.EnumerateFiles(folder);
                        foreach (var file in files)
                        {
                            var creationTime = File.GetCreationTimeUtc(file);
                            if (DateTime.UtcNow - creationTime > TimeSpan.FromMinutes(_settings.FileAgeMinutes))
                            {
                                try
                                {
                                    File.Delete(file);
                                    _logger.LogInformation("Deleted temp file: {File}", file);
                                }
                                catch (Exception ex)
                                {
                                    _logger.LogError(ex, "Error deleting file: {File}", file);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error scanning folders for temp files.");
                }

                await Task.Delay(TimeSpan.FromSeconds(_settings.ScanIntervalSeconds), stoppingToken);
            }

            _logger.LogInformation("TempFileCleanupService stopped.");
        }
    }
}
