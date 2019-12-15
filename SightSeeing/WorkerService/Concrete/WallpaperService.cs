using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using WorkerService.Abstract;

namespace WorkerService
{
    public class WallpaperService : IWallpaperService
    {
        private readonly ILogger<WallpaperService> _logger;

        public WallpaperService(ILogger<WallpaperService> logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.LogInformation("RUNNING WALLPAPER !!!");
        }
    }
}
