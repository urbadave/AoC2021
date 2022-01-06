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
        private readonly IDepthCounter _counter;

        public Worker(ILogger<Worker> logger,
            IDepthCounter counter)
        {
            _logger = logger;
            _counter = counter;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            Console.WriteLine($"Test depth increases {_counter.GetDepthIncreases(true)} times");
            Console.WriteLine($"Real depth increases {_counter.GetDepthIncreases()} times");

            Console.WriteLine($"Test depth increases {_counter.GetWindowDepthIncreases(true)} times");
            Console.WriteLine($"Real depth increases {_counter.GetWindowDepthIncreases()} times");
        }
    }
}
