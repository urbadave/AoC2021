using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Day01
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IDepthDto _depthDto;

        public Worker(ILogger<Worker> logger,
            IDepthDto depthDto)
        {
            _logger = logger;
            _depthDto = depthDto;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            Console.WriteLine($"there are {_depthDto.TestData.Count} test depths and {_depthDto.RealData.Count} real depths.");
        }
    }
}
