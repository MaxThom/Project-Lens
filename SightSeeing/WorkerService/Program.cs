using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkerService.Abstract;

namespace WorkerService
{
    public class Program
    {
        // https://codeburst.io/create-a-windows-service-app-in-net-core-3-0-5ecb29fb5ad0

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseWindowsService()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsettings.json", optional: true, true);
                    config.AddEnvironmentVariables("SIGHTSEEING_");
                    // {prefix}_{parent}__{child}__{grandchild}
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.Configure<AppSettings>(hostContext.Configuration.GetSection("AppSettings"));
                    services.AddHostedService<Worker>();
                    services.AddApplicationInsightsTelemetryWorkerService();

                    services.AddTransient<IImageService, UnsplashService>();
                    services.AddTransient<IWallpaperService, WallpaperService>();
                });
    }
}
