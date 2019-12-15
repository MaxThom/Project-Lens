using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using WorkerService.Abstract;
using System.Threading.Tasks;
using System.Text.Json;
using Model.Unsplash;

namespace WorkerService
{
    public class UnsplashService : IImageService
    {
        private readonly ILogger<UnsplashService> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public UnsplashService(ILogger<UnsplashService> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Picture>> FetchImagesAsync(string searchKey)
        {
            try
            {
                _logger.LogInformation($"Fetching images on \"{searchKey}\"");

                var client = _httpClientFactory.CreateClient(Constants.UnSplash.apiName);
                string result = await client.GetStringAsync($"/photos/random/?client_id={Constants.UnSplash.apiAccessKey}&query=cars&orientation=landscape&count=3");
                _logger.LogInformation(result);
                var pictures = JsonSerializer.Deserialize<List<Picture>>(result);

                _logger.LogInformation($"Got images");

                return pictures;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error while requesting images");
            }

            return null;
        }
    }
}