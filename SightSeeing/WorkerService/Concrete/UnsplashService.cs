using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using WorkerService.Abstract;

namespace WorkerService
{
    public class UnsplashService : IImageService
    {
        private readonly ILogger<UnsplashService> _logger;

        public UnsplashService(ILogger<UnsplashService> logger)
        {
            _logger = logger;
        }

        public void FetchImages(string searchKey)
        {
            _logger.LogInformation("FETCHING IMAGES");
        }
    }
}
