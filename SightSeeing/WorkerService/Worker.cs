using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WorkerService.Abstract;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IOptions<AppSettings> _settings;

        private readonly IWallpaperService _wallpaperService;
        private readonly IImageService _imageService;

        public Worker(ILogger<Worker> logger, IOptions<AppSettings> settings, IWallpaperService wallpaperService, IImageService imageService)
        {
            _logger = logger;
            _settings = settings;
            _wallpaperService = wallpaperService;
            _imageService = imageService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                _wallpaperService.Run();
                _imageService.FetchImages("mountain");

                await Task.Delay(3000, stoppingToken);
            }
        }
    }
}
